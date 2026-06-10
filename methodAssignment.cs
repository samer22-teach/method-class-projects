using System;

namespace MethodAssignment
{
    // Define a class to hold our custom method
    class MathOperator
    {
        // Create a void method that takes two integers as parameters
        // Void means the method does not return a value
        public void CalculateAndDisplay(int numberOne, int numberTwo)
        {
            // Perform a math operation on the first integer
            // Here, we are simply multiplying it by 10
            int result = numberOne * 10;

            // Display the second integer to the screen as requested
            Console.WriteLine("The second integer provided is: " + numberTwo);
            
            // Optional: Printing the result of the first number just for clarity
            Console.WriteLine("The result of the math operation on the first number is: " + result);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperator class (create an object)
            MathOperator mathOp = new MathOperator();

            // Call the method in the class, passing in two numbers (positional arguments)
            // numberOne will be 5, numberTwo will be 20
            mathOp.CalculateAndDisplay(5, 20);

            // Call the method in the class, specifying the parameters by name (named arguments)
            // This allows you to pass arguments in a different order if desired
            mathOp.CalculateAndDisplay(numberOne: 15, numberTwo: 100);

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

