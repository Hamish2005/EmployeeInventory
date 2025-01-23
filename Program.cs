namespace SE2250_Lab2;

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee instance
        Employee employee = new Employee();
        // Input employee data
        Console.Write("Enter employee name: ");
        employee.Name = Console.ReadLine();

        Console.Write("Enter employee ID: ");
        employee.ID = int.Parse(Console.ReadLine());

        Console.Write("Enter salary: ");
        employee.Salary = double.Parse(Console.ReadLine());

        Console.Write("Enter street: ");
        employee.address.Street = Console.ReadLine();

        Console.Write("Enter city: ");
        employee.address.City = Console.ReadLine();

        Console.Write("Enter zip code: ");
        employee.address.ZipCode = int.Parse(Console.ReadLine());
        

        // Print employee details
        employee.DisplayEmployeeDetails();
    }
}

