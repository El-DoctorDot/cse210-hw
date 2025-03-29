using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _Products;
    private Customer _OrderCustomer;

    public List<Product> Products
    {
        get { return _Products; } // Property to get or set the list of products in the order
        set { _Products = value; }
    }
    public Customer OrderCustomer
    {
        get { return _OrderCustomer; } // Property to get or set the customer who placed the order
        set { _OrderCustomer = value; }
    }

    public Order(List<Product> products, Customer orderCustomer) // Constructor to initialize the order with a list of products and the customer who placed the order
    {
        _Products = products;
        _OrderCustomer = orderCustomer;
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = 0; // Initialize the total cost to zero
        foreach (Product product in _Products) // Iterate through each product in the order
        {
            totalCost += product.GetTotalCost(); // Add the total cost of each product to the total cost of the order
        }

        // Add the shipping cost
        decimal shippingCost = _OrderCustomer.IsInUsa() ? 5 : 35;
        totalCost += shippingCost; // Add the shipping cost to the total cost

        return totalCost; // Return the total cost of the order including the shipping cost
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n"; // Initialize the packing label with a header
        foreach (Product product in _Products) // Iterate through each product in the order
        {
            packingLabel += $"{product.Name} (ID: {product.ProductId}) - Quantity: {product.Quantity}\n"; // Add product details to the packing label
        }
        return packingLabel; // Return the complete packing label
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n"; // Initialize the shipping label with a header
        shippingLabel += $"Customer Name: {_OrderCustomer.Name}\n"; // Add customer name to the shipping label
        shippingLabel += $"Address: {_OrderCustomer.CustomerAddress.GetFullAddress()}"; // Add customer address to the shipping label
        return shippingLabel; // Return the complete shipping label
    }
}
