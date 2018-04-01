using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart
{
    public class Urls
    {
        internal static string BaseUrl => "https://app.snipcart.com/api";

        public static string Orders => BaseUrl + "/orders";
        public static string Order => BaseUrl + "/orders/{0}";
        public static string Subscriptions => BaseUrl + "/subscriptions";
        public static string Subscription => BaseUrl + "/subscriptions/{0}";
        public static string SubscriptionInvoices => BaseUrl + "/subscriptions/{0}/invoices";
        public static string SubscriptionPause => BaseUrl + "/subscriptions/{0}/pause";
        public static string SubscriptionResume => BaseUrl + "/subscriptions/{0}/resume";
        public static string OrderNotifications => BaseUrl + "/orders/{0}/notifications";
        public static string OrderRefunds => BaseUrl + "/orders/{0}/refunds";
        public static string OrderRefund => BaseUrl + "/orders/{0}/refunds/{1}";
        public static string Customers => BaseUrl + "/customers";
        public static string Customer => BaseUrl + "/customers/{0}";
        public static string CustomerOrders => BaseUrl + "/customers/{0}/orders";
        public static string Discounts => BaseUrl + "/discounts";
        public static string Discount => BaseUrl + "/discounts/{0}";
        public static string UserSessions => BaseUrl + "/usersessions/{0}";
        public static string Products => BaseUrl + "/products";
        public static string Product => BaseUrl + "/product/{0}";
        public static string AbandonedCarts => BaseUrl + "/carts/abandoned";
        public static string AbandonedCart => BaseUrl + "/carts/abandoned/{0}";
        public static string Domain => BaseUrl + "/settings/domain";
        public static string AllowedDomains => BaseUrl + "/settings/alloweddomains";
        public static string ShippingMethods => BaseUrl + "/shipping_methods";
        public static string ShippingMethod => BaseUrl + "/shipping_methods/{0}";
    }
}
