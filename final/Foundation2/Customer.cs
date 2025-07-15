public class Customer
{
    private string _name;
    private Address _address;
    private Order _customerOrder = new Order();

    public Customer(string name)
    {
        _name = name;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public void SetOrder(Order order)
    {
        _customerOrder = order;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public string GetName()
    {
        return _name;
    }
    public bool IsInternational(Address address)
    {
        string _country = address.GetCountry();
        if (_country != "United States of America")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}