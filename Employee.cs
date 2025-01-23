namespace SE2250_Lab2
{
    public class Employee
    {
        // Private fields
        private string name;
        private int id;
        private double salary;
        public Address address = new Address();

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return id; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("ID must be a positive integer.");
                }
                id = value;
            }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative.");
                }
                salary = value;
            }
        }
        
        // Method to display employee details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Salary: ${Salary:F2}"); // Format salary to two decimal places
            address.DisplayAddress();
        }
    }
}