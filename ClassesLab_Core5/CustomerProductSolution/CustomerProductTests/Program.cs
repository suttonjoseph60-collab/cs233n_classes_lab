using System;
using CustomerProductClasses;

namespace CustomerProductTests
{
    class Program
    {
        static void Main(string[] args)
        {

            TestProductConstructors();
            TestProductToString();
            TestProductPropertyGetters();
            TestProductPropertySetters();

            TestCustomerConstructors();
            TestCustomerToString(); 
            TestCustomerPropertyGetters();
            TestCustomerPropertySetters();
        }

        static void TestProductConstructors()
        {
            Product p1 = new Product();
            Product p2 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing both product constructors");
            Console.WriteLine("Default constructor.  Expecting default values. " + p1.ToString());
            Console.WriteLine("Overloaded constructor.  Expecting 1, T100, 100, This is a test product, 10 " + p2.ToString());
            Console.WriteLine();
        }

        static void TestProductToString()
        {
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting 1, T100, 100, This is a test product, 10 " + p1.ToString());
            Console.WriteLine("Expecting 1, T100, 100, This is a test product, 10 " + p1);
            Console.WriteLine();
        }

        static void TestProductPropertyGetters()
        {
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing product getters");
            Console.WriteLine("Id.  Expecting 1. " + p1.Id);
            Console.WriteLine("Code.  Expecting T100. " + p1.Code);
            Console.WriteLine("Description.  Expecting This is a test product. " + p1.Description);
            Console.WriteLine("Price.  Expecting 100. " + p1.UnitPrice);
            Console.WriteLine("Quantity.  Expecting 10. " + p1.QuantityOnHand);
            Console.WriteLine();
        }

        static void TestProductPropertySetters()
        {
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing product setters");
            p1.Id = 2;
            p1.Code = "T000";
            p1.Description = "First product";
            p1.UnitPrice = 200;
            p1.QuantityOnHand = 20;
            Console.WriteLine("Expecting 2, T000, 200, First product, 20 " + p1);
            Console.WriteLine();
        }

        static void TestCustomerConstructors()
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer(1, "John", "Smith", "john.smith@example.com", "123-456-7890");

            Console.WriteLine("Testing both customer constructors");
            Console.WriteLine("Default constructor.  Expecting default values. " + c1.ToString());
            Console.WriteLine("Overloaded constructor.  Expecting 1, John, Smith, john.smith@example.com, 123-456-7890 " + c2.ToString());
            Console.WriteLine();
        }

        static void TestCustomerToString()
        {
            Customer c1 = new Customer(1, "John", "Smith", "john.smith@example.com", "123-456-7890");

            Console.WriteLine("Testing customer ToString");
            Console.WriteLine("Expecting 1, John, Smith, john.smith@example.com, 123-456-7890 " + c1.ToString());
            Console.WriteLine("Expecting 1, John, Smith, john.smith@example.com, 123-456-7890 " + c1);
            Console.WriteLine();
        }

        static void TestCustomerPropertyGetters()
        {
            Customer c1 = new Customer(1, "John", "Smith", "john.smith@example.com", "123-456-7890");

            Console.WriteLine("Testing customer getters");
            Console.WriteLine("Id.  Expecting 1. " + c1.Id);
            Console.WriteLine("FirstName.  Expecting John. " + c1.FirstName);
            Console.WriteLine("LastName.  Expecting Smith. " + c1.LastName);
            Console.WriteLine("Email.  Expecting john.smith@example.com. " + c1.Email);
            Console.WriteLine("PhoneNumber.  Expecting 123-456-7890. " + c1.PhoneNumber);
            Console.WriteLine();
        }

        static void TestCustomerPropertySetters()
        {
            Customer c1 = new Customer(1, "John", "Smith", "john.smith@example.com", "123-456-7890");

            Console.WriteLine("Testing customer setters");
            c1.Id = 2;
            c1.FirstName = "Jane";
            c1.LastName = "Doe";
            c1.Email = "jane.doe@example.com";
            c1.PhoneNumber = "987-654-3210";
            Console.WriteLine("Expecting 2, Jane, Doe, jane.doe@example.com, 987-654-3210 " + c1);
            Console.WriteLine();
        }
    }
}