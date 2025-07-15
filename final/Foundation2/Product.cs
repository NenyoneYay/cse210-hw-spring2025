public class Product
{
    private string _productName;
    private int _productID;
    private double _productPrice;

    public Product(string name, int ID, double price)
    {
        _productName = name;
        _productID = ID;
        _productPrice = price;
    }

    public double GetPrice()
    {
        return _productPrice;
    }

    public string GetName()
    {
        return _productName;
    }
    public int GetID()
    {
        return _productID;
    }
}