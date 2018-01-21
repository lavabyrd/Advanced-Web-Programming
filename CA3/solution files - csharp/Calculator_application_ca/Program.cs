using System;

namespace Calculator_application_ca
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            calculator sq = new calculator();
            Console.WriteLine(sq.Square(12));  
                Console.WriteLine(sq.Add(8, 63));  
                Console.WriteLine(sq.Multiply(5, 8));  
                Console.WriteLine(sq.Subtract(10, 42));  
                Console.WriteLine(sq.Division(3, 4));  
                Console.ReadLine();  

        }
    }
}
