using System.Data.Common;

class Product
{
    private int _id;
    private string _name;
    private int _pricePerUnit;
    private int _quantity;

    public Product(int id, string name, int pricePerUnit, int quantity)
    {
        _id = id;
        _name = name;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public int GetID()
    {
        return _id;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPrice()
    {
        return _pricePerUnit * _quantity;
    }
}