public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;
    private double _orderCost;
    private double _shippingCost;

    public void AddProduct(Product product, int count)
    {
        int i = 1;
        while (i <= count)
        {
            _productList.Add(product);
            i += 1;
        }
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public double CalculateCost(bool international)
    {
        _orderCost = 0;
        foreach (Product product in _productList)
        {
            _orderCost += product.GetPrice();
        }
        if (international == true)
        {
            _shippingCost = 15;
        }
        else
        {
            _shippingCost = 5;
        }
        _orderCost += _shippingCost;
        return Math.Round(_orderCost, 2);
    }

    public double GetShippingCost()
    {
        return _shippingCost;
    }

    public void PackingLabel()
    {
        Console.WriteLine("Packing label: ");
        foreach (Product product in _productList)
        {
            Console.WriteLine(product.GetName() + ": #" + product.GetID());
        }
        Console.WriteLine();
    }
    public void ShippingLabel()
    {
        Console.WriteLine("Shipping label:");
        Address _address = _customer.GetAddress();
        Console.WriteLine("Name: " + _customer.GetName() + "\nAddress: " + _address.GetAddressInfo());
        Console.WriteLine();
    }
}