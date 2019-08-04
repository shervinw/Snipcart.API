namespace Snipcart
{
    public abstract class SnipcartService
    {
        internal SnipcartHttpClient _httpClient;

        public SnipcartService(string apiKey)
        {
            if (_httpClient == null)
                _httpClient = new SnipcartHttpClient(apiKey);
        }
    }
}
