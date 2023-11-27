using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20Part1Day16
{
    internal class Program
    {
        internal delegate int ArithemeticOperation(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("Arithematic operation");
            Console.WriteLine("Enter the first Number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int number2 = int.Parse(Console.ReadLine());
            Calc calc = new Calc();
            ArithemeticOperation del = new ArithemeticOperation(calc.Add);
            ArithemeticOperation del1 = new ArithemeticOperation(calc.Subtarct);
            ArithemeticOperation del2 = new ArithemeticOperation(calc.Multi);
            ArithemeticOperation del3 = new ArithemeticOperation(calc.Divide);

            Console.WriteLine("Enter the choice for desired operation \n 1.Addition \n 2.Subtraction \n 3.Multiplication \n 4.Divided");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {

                        int result = del(number, number2);
                        Console.WriteLine($"Addition of number {number} and {number} is"+result);
                        break;
                    }
                case 2:
                    {
                        int result = del1(number, number2);
                        Console.WriteLine($"Addition of number {number} and {number} is" + result);
                        break;
                    }
                case 3:
                    {
                        int result = del2(number, number2);
                        Console.WriteLine($"Addition of number {number} and {number} is" + result);
                        break;
                    }
                case 4:
                    {
                        int result = del3(number, number2);
                        Console.WriteLine($"Addition of number {number} and {number} is" + result);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Operation");
                        break;
                    }
            }
            Console.ReadKey();

        }
    }
}
