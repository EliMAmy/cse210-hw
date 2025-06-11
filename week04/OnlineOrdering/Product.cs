using System;

public class Product
{
    private string _nameProduct;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string nameProduct, string id, double price, int quantity)
    {
        _nameProduct = nameProduct;
        _productID = id;
        _price = price;
        _quantity = quantity;
    }

    public double CostProduct()
    {
        double cost = _price * _quantity;
        return cost;
    }
    public string GetPackingInfo()
    {
        return ($"{_nameProduct}-(ID: {_productID})");
    }
}