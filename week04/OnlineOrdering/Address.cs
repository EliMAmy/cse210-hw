using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string province, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = province;
        _country = country;
    }
    public bool IsInUSA()
    {
        if (_country == "USA")
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

        return ($"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}");
    }
}