using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Snipcart.Models;


namespace Snipcart
{
    public class SnipcartClient : SnipcartService
    {
        private SnipcartClient() : base(null)
        {
            throw new ArgumentNullException("Must provide an API key generated from your Snipcart dashboard");
        }
        public SnipcartClient(string apiKey) : base(apiKey) { }

        #region Orders
        public virtual Task<Orders> GetOrdersAsync()
        {
            return _httpClient.GetObject<Orders>(Urls.Orders);
        }
        public virtual Task<Orders> GetOrdersAsync(OrdersRequestOptions options)
        {
            string url = Urls.Orders + options.GetUrlParams();
            return _httpClient.GetObject<Orders>(url);
        }
        public virtual Task<Order> GetOrderAsync(string orderToken)
        {
            var url = string.Format(Urls.Order, orderToken);
            return _httpClient.GetObject<Order>(url);
        }
        public virtual Task<Order> UpdateOrderAsync(string orderToken, OrderPutOptions options)
        {
            var url = string.Format(Urls.Order, orderToken);
            return _httpClient.PutObject<Order>(url, options);
        }
        #endregion

        public virtual Task<Subscriptions> GetSubscriptionsAsync(SubscriptionsRequestOptions options)
        {
            string url = Urls.Subscriptions + options.GetUrlParams();
            return _httpClient.GetObject<Subscriptions>(url);
        }
        public virtual Task<Subscription> GetSubscriptionAsync(string subscriptionid)
        {
            var url = string.Format(Urls.Subscription, subscriptionid);
            return _httpClient.GetObject<Subscription>(url);
        }
        public virtual Task<SnipcartList<Invoice>> GetSubscriptionInvoicesAsync(string subscriptionid)
        {
            var url = string.Format(Urls.SubscriptionInvoices, subscriptionid);
            return _httpClient.GetObject<SnipcartList<Invoice>>(url);
        }
        public virtual Task<Subscription> DeleteSubscriptionAsync(string subscriptionid)
        {
            var url = string.Format(Urls.Subscription, subscriptionid);
            return _httpClient.DeleteObject<Subscription>(url);
        }
        public virtual Task<Subscription> PauseSubscriptionAsync(string subscriptionid)
        {
            var url = string.Format(Urls.SubscriptionPause, subscriptionid);
            return _httpClient.PostObject<Subscription>(url, "");
        }
        public virtual Task<Subscription> ResumeSubscriptionAsync(string subscriptionid)
        {
            var url = string.Format(Urls.SubscriptionResume, subscriptionid);
            return _httpClient.PostObject<Subscription>(url, "");
        }

        public virtual Task<Notifications> GetOrderNotificationsAsync(string orderToken, OrderNotificationsRequestOptions options)
        {
            var url = string.Format(Urls.OrderNotifications, orderToken) + options.GetUrlParams();
            return _httpClient.GetObject<Notifications>(url);
        }

        public virtual Task<Notifications> PostOrderNotificationAsync(string orderToken, OrderNotificationPostOptions options)
        {
            var url = string.Format(Urls.OrderNotifications, orderToken);
            return _httpClient.PostObject<Notifications>(url, options);
        }

        public virtual Task<SnipcartList<Refund>> GetOrderRefundsAsync(string orderToken)
        {
            var url = string.Format(Urls.OrderRefunds, orderToken);
            return _httpClient.GetObject<SnipcartList<Refund>>(url);
        }
        public virtual Task<Refund> GetOrderRefundAsync(string orderToken, string refundId)
        {
            var url = string.Format(Urls.OrderRefund, orderToken, refundId);
            return _httpClient.GetObject<Refund>(url);
        }
        public virtual Task<Refund> PostOrderRefundAsync(string orderToken, RefundPostOptions options)
        {
            var url = string.Format(Urls.OrderRefunds, orderToken);
            return _httpClient.PostObject<Refund>(url, options);
        }

        public virtual Task<Customers> GetCustomersAsync(string orderToken, CustomersRequestOptions options)
        {
            var url = Urls.Customers + options.GetUrlParams();
            return _httpClient.GetObject<Customers>(url);
        }

        public virtual Task<User> GetCustomerAsync(string customerId)
        {
            var url = string.Format(Urls.Customer, customerId);
            return _httpClient.GetObject<User>(url);
        }

        public virtual Task<SnipcartList<Order>> GetCustomerOrdersAsync(string customerId)
        {
            var url = string.Format(Urls.CustomerOrders, customerId);
            return _httpClient.GetObject<SnipcartList<Order>>(url);
        }

        public virtual Task<SnipcartList<Discount>> GetDiscountsAsync()
        {
            return _httpClient.GetObject<SnipcartList<Discount>>(Urls.Discounts);
        }
        public virtual Task<Discount> GetDiscountAsync(string discountId)
        {
            var url = string.Format(Urls.Discount, discountId);
            return _httpClient.GetObject<Discount>(url);
        }

        public virtual Task<Discount> PostDiscountAsync(DiscountOptions options)
        {
            return _httpClient.PostObject<Discount>(Urls.Discounts, options);
        }
        public virtual Task<Discount> UpdateDiscountAsync(string discountId, DiscountOptions options)
        {
            var url = string.Format(Urls.Discount, discountId);
            return _httpClient.PutObject<Discount>(url, options);
        }

        public virtual Task<Discount> DeleteDiscountAsync(string discountId)
        {
            var url = string.Format(Urls.Discount, discountId);
            return _httpClient.DeleteObject<Discount>(url);
        }

        public virtual Task<UserSessions> GetUserSessionsAsync(string sessionToken)
        {
            var url = string.Format(Urls.Discount, sessionToken);
            return _httpClient.GetObject<UserSessions>(url);
        }

        public virtual Task<Products> GetProductsAsync(ProductsRequestOptions options)
        {
            var url = Urls.Products + options.GetUrlParams();
            return _httpClient.GetObject<Products>(url);
        }

        public virtual Task<Product> GetProductAsync(string productId)
        {
            var url = string.Format(Urls.Product, productId);
            return _httpClient.GetObject<Product>(url);
        }

        public virtual Task<SnipcartList<Product>> PostProductAsync(ProductPostOptions options)
        {
            return _httpClient.PostObject<SnipcartList<Product>>(Urls.Products, options);
        }

        public virtual Task<Product> UpdateProductAsync(string productId, ProductPutOptions options)
        {
            var url = string.Format(Urls.Product, productId);
            return _httpClient.PostObject<Product>(url, options);
        }

        public virtual Task<Product> DeleteProductAsync(string productId)
        {
            var url = string.Format(Urls.Product, productId);
            return _httpClient.DeleteObject<Product>(url);
        }

        public virtual Task<AbandonedCarts> GetAbandonedCartsAsync(AbandonedCartsRequestOptions options)
        {
            var url = Urls.AbandonedCarts + options.GetUrlParams();
            return _httpClient.GetObject<AbandonedCarts>(url);
        }

        public virtual Task<AbandonedCart> GetAbandonedCartAsync(string abandonedCartToken)
        {
            var url = string.Format(Urls.AbandonedCart, abandonedCartToken);
            return _httpClient.GetObject<AbandonedCart>(url);
        }
    }
}
