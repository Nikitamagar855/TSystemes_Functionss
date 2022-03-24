using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystemes_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmaticOperation objAO = new ArithmaticOperation();
            objAO.Addition();
            objAO.substraction();
            Console.ReadLine();


        }


    }


    public class ArithmaticOperation
    {
        public void Addition()
        {
            int x = 69;
            int y = 88;
            int sum = x + y;
            Console.WriteLine($"Addition is{sum}");


        }
        public void substraction()
        {
            int a = 55;
            int b = 44;
            int sub = a - b;
            Console.WriteLine($"Substraction is {sub}");
        }
        public void multiplication()
        {
            int a = 55;
            int b = 44;
            int mult = a * b;
            Console.WriteLine($"Multiplication is {mult}");
        }
        public void Division()
        {
            int a = 55;
            int b = 44;
            int div = a / b;
            Console.WriteLine($"Division is {div}");
        }



    }


}