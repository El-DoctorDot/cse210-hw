using System;

public class Address  // This class represents a physical address and provides methods to check if the address is in the USA and to get the full address as a string.
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public string StreetAddress
    {
        get { return _streetAddress; } // Property to get or set the street address
        set { _streetAddress = value; }
    }

    public string City
    {
        get { return _city; } // Property to get or set the city
        set { _city = value; } 
    }

    public string StateProvince
    {
        get { return _stateProvince; } // Property to get or set the state or province
        set { _stateProvince = value; }
    }

    public string Country
    {
        get { return _country; } // Property to get or set the country
        set { _country = value; }
    }

    public Address(string streetAddress, string city, string stateProvince, string country) // Constructor to initialize the address with street address, city, state/province, and country
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    
    public bool IsInUsa() // This method checks if the address is in the USA by comparing the country string to known values.
    {
        return _country.ToLower() == "usa" || _country.ToLower() == "u.s.a." || _country.ToLower() == "united states";
    }

   
    public string GetFullAddress() // This method returns the full address as a formatted string.
    {
        return $"{_streetAddress}\n{_city}\n{_stateProvince}\n{_country}";
    }
}
