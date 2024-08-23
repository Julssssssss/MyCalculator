using System;

namespace calcu
{
    internal class Program
    {
        class Calculator 
        {
            private double FirstNum;
            private double SecNum;

            public void SetNumbers()
            {
                try
                {
                    Console.WriteLine("Enter 1st number: ");
                    FirstNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number: ");
                    SecNum = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e )
                {
                    InvalidInput();
                    Environment.Exit(1); // immediately terminate the process.
                }
            
            }

            public void Addition()
            {
                double answer = FirstNum + SecNum;
                Console.WriteLine("Answer: "+ answer);
            }
            public void Multiplication()
            {
                double answer = FirstNum * SecNum;
                Console.WriteLine("Answer: "+ answer);
            }

            public void Subtraction()
            {
                double answer = FirstNum - SecNum;
                Console.WriteLine("Answer: "+ answer);
            }

            public void InvalidInput() // for error message handling
            {
                Console.WriteLine("Invalid Input");
            }
        }

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(); // this is the instance or object 
            calculator.SetNumbers();
           
            Console.WriteLine("Enter Operator: ");
            string operation = Console.ReadLine();

            if(operation == "+")
            {
                calculator.Addition();
            }else if(operation == "*")
            {
                calculator.Multiplication();
            }else if(operation == "-")
                calculator.Subtraction();
            else{
                calculator.InvalidInput();
            }

            //Console.WriteLine("Hello World!");
            //Console.WriteLine("enter eme:");
            //int eme = Console.ReadLine(); note: this only accepts string input whenever you put certain data type.(IT STILL ONLY ACCEPT STRING)
            //int eme = Convert.ToInt32(Console.ReadLine());
            //get set property for accessing or updating private class or field
            /*
                get- used to return the property value. 
                set - used to assign a new value.
                init - idunno 
            */
            //enums predefind list of data that is constant 
            // next is property definition and usage.
            /*
                public static void Add() - it belongs to the class itself 
                public void Add() - Hindi ko magets huhuhhuh help 
                creating an instance of a class to pass 
                class is the blueprint hehe
            */
        }
    }
}