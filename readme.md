Snipcart API, supporting .NET Standard 1.6+

## Reference

See the [Snipcart API Reference docs](https://docs.snipcart.com/).

## Installation

### Install Snipcart.API via NuGet

Coming soon

## Usage 

### Initialise the Snipcart client

```csharp
SnipcartClient client = new SnipcartClient("[your api key here]");
```

You can obtain your secret API key from the [API Keys](https://app.snipcart.com/dashboard/account/credentials) section in the Dashboard.

### Get Request Example

```csharp
Orders orders = client.GetOrdersAsync(new OrdersRequestOptions() { status = OrderStatus.Shipped }).Result;
if (orders.IsSuccessStatusCode) //returned 200, 201, 204
{
    //do stuff
}
else
{
    var errormessage = orders.message;
    var statuscode = orders.statuscode;
    var errors = orders.errors.parameter;
}
```

### Update Request Example

```csharp
Order order = client.UpdateOrderAsync("[order token/guid]", new OrderPutOptions() { trackingUrl = "http://test.com" }).Result;
```

## Implemented endpoints

```
* GET /orders
* GET /orders/{token}
* PUT /orders/{token}
* GET /subscriptions
* GET /subscriptions/{id}
* GET /subscriptions/{id}/invoices
* DELETE /subscriptions/{id}
* POST /subscriptions/{id}/pause
* POST /subscriptions/{id}/resume
* GET /orders/{token}/notifications
* POST /orders/{token}/notifications
* GET /orders/{token}/refunds
* GET /orders/{token}/refunds/{id}
* POST /orders/{token}/refunds
* GET /customers
* GET /customers/{id}
* GET /customers/{id}/orders
* GET /discounts
* GET /discounts/{id}
* POST /discounts
* PUT /discounts/{id}
* DELETE /discounts/{id}
* GET /usersessions/{token}
* GET /products
* GET /products/{id}
* POST /products
* PUT /products/{id}
* DELETE /products/{id}
* GET /carts/abandoned
* GET /carts/abandoned/{token}
```

## Contribution Guidelines

Contributions are more than welcome. If you'd like to submit a pull request, it's best to start with an issue to describe what you'd like to build.
