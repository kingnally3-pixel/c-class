using System;
namespace HardwareStoreInventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, businessName, gender;
            int age;
            float startingCapital, price; // Variables to hold decimal money values
            int quantity;

            Console.WriteLine("Welcome to Stream!!! \nYour hardware inventory");

            Console.WriteLine("What is your name:");
            userName = Console.ReadLine();

            Console.WriteLine("What is your business name:");
            // businessName = Console.ReadLine();
            businessName = "Stream";
            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine()); //  convert it to an integer
            Console.WriteLine("What is your gender? (male/female)");
            gender = Console.ReadLine().ToLower(); //convert to lowercase

            if (gender == "male")
            {
                Console.WriteLine($"hello Mr. {userName}, you are welcome to {businessName}");

            }
            else if (gender == "female")
            {
                Console.WriteLine($"hello Mrs. {userName}, you are welcome to {businessName}");
            }
            else Console.WriteLine($"hello {userName}, you are welcome to {businessName}");
            
             Console.WriteLine($"{userName}, you are welcome to {businessName}");
            
            Console.WriteLine("How much capital did you start your business with?");
            startingCapital = Convert.ToSingle(Console.ReadLine()); //  float 

            string addAnother = "yes"; //  loop keeps running
            while (addAnother == "yes") // Loop continues as long as user says "yes"
            {
                Console.WriteLine("What is the price of your product?");
                price = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("How many units of this product are in stock?");
                quantity = Convert.ToInt32(Console.ReadLine()); //  integer

                float totalStockValue = price * quantity; 
              Console.WriteLine("\n--- Inventory Summary ---");
                Console.WriteLine($"Business: {businessName}");
                Console.WriteLine($"Owner: {userName}, Age: {age}");
                Console.WriteLine($"Starting Capital: {startingCapital:C}");
                Console.WriteLine($"Product Price: {price:C}");
                Console.WriteLine($"Units in Stock: {quantity}");
                Console.WriteLine($"Total Stock Value: {totalStockValue:C}");

                Console.WriteLine("\nAdd another product? (yes/no)"); 
                addAnother = Console.ReadLine().ToLower(); // Read answer, feed back into loop condition
            }
            

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}




