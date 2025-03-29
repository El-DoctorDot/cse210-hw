using System;

public class Product
{
    private string _name;
    private int _productId; 
    private decimal _price;
    private int _quantity;

    public string Name
    {
        get { return _name; } // Property to get or set the product name
        set { _name = value; }
    }

    public int ProductId
    {
        get { return _productId; } // Property to get or set the product ID
        set { _productId = value; }
    }

    public decimal Price
    {
        get { return _price; } // Property to get or set the product price
        set { _price = value; }
    }

    public int Quantity
    {
        get { return _quantity; } // Property to get or set the product quantity
        set { _quantity = value; }
    }

    // Constructor to initialize the product with name, ID, price, and quantity
    public Product(string name, int productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId; // Initialize the product ID
        _price = price;
        _quantity = quantity;
    }

    // This method calculates the total cost of the product by multiplying the price by the quantity
    public decimal GetTotalCost()
    {
        return _price * _quantity; // returns the total cost of the product
    }
}
