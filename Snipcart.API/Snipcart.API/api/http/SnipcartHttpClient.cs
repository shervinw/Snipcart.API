using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Snipcart
{
    internal class SnipcartHttpClient
    {
        private static HttpClient _client = new HttpClient();
        public SnipcartHttpClient(string key)
        {
            var basekey = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(":" + key));
            _client.DefaultRequestHeaders.Add("Authorization", "Basic " + basekey);
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<T> GetObject<T>(string url) where T : IResponseBase
        {
            HttpResponseMessage response = await _client.GetAsync(url).ConfigureAwait(false);
            return await ParseResponse<T>(response);
        }

        public async Task<T> DeleteObject<T>(string url) where T : IResponseBase
        {
            HttpResponseMessage response = await _client.DeleteAsync(url).ConfigureAwait(false);
            return await ParseResponse<T>(response);
        }

        public async Task<T> PutObject<T>(string url, object input) where T : IResponseBase
        {
            var inputString = JsonConvert.SerializeObject(input, Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore,
                                DefaultValueHandling = DefaultValueHandling.Ignore
                            });
            var content = new StringContent(inputString == null ? "" : inputString, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PutAsync(url, content).ConfigureAwait(false);
            return await ParseResponse<T>(response);
        }

        public async Task<T> PostObject<T>(string url, object input) where T : IResponseBase
        {
            var inputString = JsonConvert.SerializeObject(input, Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore,
                                DefaultValueHandling = DefaultValueHandling.Ignore
                            });
            var content = new StringContent(inputString == null ? "" : inputString, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PostAsync(url, content).ConfigureAwait(false);
            return await ParseResponse<T>(response);
        }

        private async Task<T> ParseResponse<T>(HttpResponseMessage response) where T : IResponseBase
        {
            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync();
                var ret = JsonConvert.DeserializeObject<T>(responseJson);
                ret.statuscode = response.StatusCode;
                return ret;
            }
            else
            {
                T ret = (T)Activator.CreateInstance(typeof(T));
                ret.message = await response.Content.ReadAsStringAsync();
                ret.statuscode = response.StatusCode;
                return ret;
            }
        }
    }
}
