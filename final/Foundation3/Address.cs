class Address
{
    public string _streetAddress;
    public string _city;
    public string _state;
    public string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddressString()
    {
        return $"{_streetAddress} {_city}, {_state}, {_country}";
    }
}