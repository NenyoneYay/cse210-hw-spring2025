public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private string _addressInfo;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string GetAddressInfo()
    {
        _addressInfo = (_streetAddress + "\n" + _city + " " + _state + "\n" + _country);
        return _addressInfo;
    }
}