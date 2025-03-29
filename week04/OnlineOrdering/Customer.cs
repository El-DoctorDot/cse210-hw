using System;

public class Customer
{
    private string _name;
    private Address _customerAddress; // This class represents a customer and contains properties for the customer's name and address, as well as methods to check if the customer is located in the USA.

    public string Name
    {
        get { return _name; }  // Property to get or set the customer's name
        set { _name = value; }
    }

    public Address CustomerAddress
    {
        get { return _customerAddress; } // Property to get or set the customer's address
        set { _customerAddress = value; }
    }

    // Constructor to initialize the customer with name and address
    public Customer(string name, Address customerAddress)
    {
        _name = name;
        _customerAddress = customerAddress;
    }

    // This method checks if the customer is located in the USA by calling the IsInUsa method of the Address class.
    public bool IsInUsa()
    {
        return _customerAddress.IsInUsa(); 
    }
}
