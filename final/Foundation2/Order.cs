public class Order
{
    private double _total;
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private List<string> strings = new List<string>();
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public double GetOrderTotal()
    {
        foreach (Product product in _products)
        {
            _total += product.GetProductPrice();
        }
        if (!_customer.GetCustomerInUS())
        {
            _total += 5;
        }
        return _total;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetCustomerAddress()}";
    }
    public string GetPackingLabels()
    {
        foreach (Product product in _products)
        {
            strings.Add($"{product.GetProductName()} - {product.GetId()}");
        }
        return String.Join("\n", strings);
    }
}