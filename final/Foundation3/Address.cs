public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zip;

    public Address(string street, string city, string state, string zip)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _zip = zip;
    }
    public void DisplayAddress()
    {
        Console.WriteLine(_streetAddress + "\n" + _city + ", " + _state + " " + _zip);
    }
}