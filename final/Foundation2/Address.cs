public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = state;
        _country = country;
    }
    public bool GetInUS()
    {
        if (_country.ToUpper() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}