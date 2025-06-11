using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    
    public Customer GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public List<Product> GetList()
    {
        return _products;
    }
    public void SetList(Product product)
    {
        _products.Add(product);
    }
    public double TotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total = total + product.CostProduct();

        }
        if (_customer.WhereLive() == true)
        {
            total = total + 5;
        }
        else
        {
            total = total + 35;
        }
        return total;
    }
    public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetPackingInfo());
        }
    }
    public void DisplayShippingLabel()
    {
       
            Console.WriteLine(_customer.GetShippingInfo());
       
    }
}