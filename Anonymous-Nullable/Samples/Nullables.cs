using System;

namespace Anonymous_Nullable.Samples
{
    public class Nullables
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? Age { get; set; }

        public double? Salary { get; set; }

        public int? WorkingExperience { get; set; }

        public int? NumberOfChildren { get; set; }

        public void Display()
        {
            Console.WriteLine("*** Employee data ***");
            Console.WriteLine($"Id: #{Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Working Experience: {WorkingExperience}");
            Console.WriteLine($"Number of children: {NumberOfChildren}");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
