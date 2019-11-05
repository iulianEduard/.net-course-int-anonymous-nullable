using Anonymous_Nullable.Samples;
using System;

namespace Anonymous_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void AnonymusObjectExample()
        {
            var anonymus = new AnonymousExample();
            anonymus.Example();

            Console.ReadKey();
        }

        static void AnonymusReturnTypeExample()
        {
            var anonymus = new AnonymousExample();
            var anonymustType = anonymus.ReturnAnonymus();

            Console.WriteLine(anonymustType);

            /*
             * We see its values, however the properties are not strong type
             * hence we cannot access them
             */

            Console.ReadKey();
        }

        static void NullableExamples()
        {
            var nullableExample1 = new Nullables
            {
                Id = 1,
                Age = 22
            };

            nullableExample1.Display();

            if (string.IsNullOrWhiteSpace(nullableExample1.Name))
            {
                nullableExample1.Name = "Jorah";
            }

            nullableExample1.Display();

            nullableExample1.Salary = nullableExample1.Salary ?? 999.99;
            nullableExample1.WorkingExperience = nullableExample1.WorkingExperience != null
                ? nullableExample1.WorkingExperience : 21;

            nullableExample1.Display();

            if(nullableExample1.NumberOfChildren.HasValue)
            {
                Console.WriteLine($"--> {nullableExample1.Name} has {nullableExample1.NumberOfChildren.Value} children");
            }
            else
            {
                Console.WriteLine($"--> {nullableExample1.Name} has no children");
            }


            nullableExample1.Display();

            Console.ReadKey();
        }

        static void NullableExamples2()
        {
            Nullables nullables = new Nullables();

            var random = new Random();
            int number = random.Next(1, 10);

            if(number % 2 == 0)
            {
                nullables = new Nullables();
                Console.WriteLine("Create class instance");
            }
            else
            {
                nullables = null;
                Console.WriteLine("Assign null to class");
            }

            /*
             * All classes are nullable, however we cannot use any class members
             * until we instance the class
             */
            // nullables.Display();

            if (nullables == null)
                nullables = new Nullables();

            nullables.Display();

            Console.ReadKey();
        }
    }
}
