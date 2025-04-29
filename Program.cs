// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//create a ElectronicItem class and initialize with some properties
public class ElectronicItem
{
    public string Name { get; set; }
    public string Brand { get; set; }
    public double Price { get; set; }
    public int WarrantyPeriod { get; set; } // in months
    public ElectronicItem(string name, string brand, double price, int warrantyPeriod)
    {
        Name = name;
        Brand = brand;
        Price = price;
        WarrantyPeriod = warrantyPeriod;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Brand: {Brand}, Price: {Price}, Warranty Period: {WarrantyPeriod} months");
    }
}
