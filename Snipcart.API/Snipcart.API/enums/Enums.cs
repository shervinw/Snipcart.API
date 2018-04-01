using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart
{
    public enum OrderStatus
    {
        InProgress,
        Processed,
        Disputed,
        Shipped,
        Delivered,
        Pending,
        Cancelled
    }

    public enum SubscriptionStatus
    {
        Active,
        Paused,
        Cancelled
    }

    public enum NotificationType
    {
        Comment,
        OrderStatusChanged,
        OrderShipped,
        TrackingNumber
    }

    public enum DeliveryMethod
    {
        Email,
        None
    }

    public enum CustomerStatus
    {
        Confirmed,
        Unconfirmed
    }

    public enum DiscountTrigger
    {
        Total,
        Code,
        Product
    }

    public enum DiscountType
    {
        FixedAmount,
        Rate,
        AlternatePrice,
        Shipping
    }

    public enum ProductInventoryManagementMethod
    {
        Single,
        Variant
    }

    public enum TimeRange
    {
        Anytime,
        LessThan4Hours,
        LessThanADay,
        LessThanAWeek,
        LessThanAMonth
    }
}
