using System;

namespace HelloMethodName
{
    public class HelloMethod
    {
        //Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

        public static string Hello(string name)
        {
            string greeting = "Hello, " + name + "!";
            return greeting;
        }

        static void Main()
        {
            //Get the name
            Console.Write("What's your name : ");
            string myName = Console.ReadLine();

            Console.WriteLine(Hello(myName)); //Sends the variable to the method and prints the result

        }
    }
}
