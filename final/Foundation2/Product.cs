public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;
    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public string GetProductName()
    {
        return _name;
    }
    public string GetId()
    {
        return _id;
    }
    public double GetProductPrice()
    {
        return _price * _quantity;
    }
}