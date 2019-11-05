using System;

namespace Anonymous_Nullable.Samples
{
    public class AnonymousExample
    {
        public void Example()
        {
            var employee = new
            {
                Id = 1,
                Name = "Jon Snow",
                Age = 28,
                Location = "Knight's watch"
            };

            Console.WriteLine("Anonymus properties:");
            Console.WriteLine($"Id: #{employee.Id}");
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Age: {employee.Age}");
            Console.WriteLine($"Location: {employee.Location}");
        }

        public object ReturnAnonymus()
        {
            var employee = new
            {
                Id = 1,
                Name = "Jon Snow",
                Age = 28,
                Location = "Knight's watch"
            };

            return employee;
        }
    }
}
