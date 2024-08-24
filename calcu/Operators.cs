using System;

namespace calcu
{
    class Operators
    {
        private string Operation = string.Empty;
        private double FirstNum;
        private double SecNum;

        public void Inputs()
        {
            try{
                Console.WriteLine("Enter 1st number: ");
                FirstNum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter 2nd number: ");
                SecNum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter operand: ");
                Operation = Console.ReadLine();
                Operations();
            }catch (Exception)
            {
                throw new ArgumentException("Invalid input");
            }
        }

        public void Operations()
        {
            if (Operation == "+")
            {
                double total = FirstNum + SecNum;
                Console.WriteLine("Answer: "+ total);
            }else{
                throw new ArgumentException("Invalid input");
            }
        }
    }
}