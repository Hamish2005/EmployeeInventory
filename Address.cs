namespace SE2250_Lab2;

// Define the Address struct (Value Type)
public struct Address
{
    //Add Fields
    public string Street;
    public string City;
    public int ZipCode;
 
    // Method to display address details
    public void DisplayAddress()
    {
        Console.WriteLine($"Address: {Street}, {City}, {ZipCode}");
    }
}