using System.Collections.Generic;  

public class Order  
{  
    private List<Product> _products;  
    private Customer _customer;  

    public Order(Customer customer)  
    {  
        _products = new List<Product>();  
        _customer = customer;  
    }  

    public void AddProduct(Product product)  
    {  
        _products.Add(product);  
    }  

    public decimal CalculateTotalPrice()  
    {  
        decimal totalProductCost = 0;  
        foreach (var product in _products)  
        {  
            totalProductCost += product.GetTotalCost();  
        }  

        decimal shippingCost = _customer.LivesInUSA() ? 5.00m : 35.00m;  
        return totalProductCost + shippingCost;  
    }  

    public string GetPackingLabel()  
    {  
        string label = "Packing Label:\n";  
        foreach (var product in _products)  
        {  
            label += $"{product.Name} (ID: {product.ProductId})\n";  
        }  
        return label;  
    }  

    public string GetShippingLabel()  
    {  
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddressString()}";  
    }  
}  