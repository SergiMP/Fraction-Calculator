using System;
using System.Globalization;
using System.Net.Sockets;
using System.Threading.Channels;
using System.Reflection;
using static RationalNumbers.IntNumberExtension;

namespace RationalNumbers
{
    class Program
    {
       
        static void Main()
        {

            Console.WriteLine("Welcome to the fraction calculator!.\n");
            Console.WriteLine("To create a new Rational Number do as follows => IrationalNumber fraction = new RationalNumber(a , b ).\n");
            Console.WriteLine("Where  a is any positive or negative integer and b != 0.\n");
            Console.WriteLine("Parameters can be: - A single integer to express rational numbers in the form a/1\n");
            Console.WriteLine("Parameters can be: - Two integers to express rational numbers in the form a/b\n");
            Console.WriteLine("Parameters can be: - Strings in the form \"a\" \"a\\b\" or \"a b\" \n");
            Console.WriteLine("You can perform arithmetic operations on IrationalNumber objects using the inline operators + - * /\n");
            Console.WriteLine("For example:\n");
            Console.WriteLine("IrationalNumber fractionA = new RationalNumber(a1 , b1 ).\n");
            Console.WriteLine("IrationalNumber fractionB = new RationalNumber(a2 , b2 ).\n");
            Console.WriteLine("IrationalNumber fractionC = fractionA + fractionB\n");
            Console.WriteLine("Alternatively you can do obj1.Add(obj2), obj1.Subtract(obj2), obj1.Multiply(obj2), obj1.Divide(obj2)\n");
            Console.WriteLine("You can also do exponentiation of a real number in two ways, 1) integer.ExpReal(obj1) or 2) ExpReal(this int intNumber, RationalNumber r).\n");
            Console.WriteLine("You can also exponentiate a rational number obj1.ExpRational(integer)\n");
            IRationalNumber fractionA = new RationalNumber(1,2);
            IRationalNumber fractionB = new RationalNumber("2");
            IRationalNumber fractionC = new RationalNumber("2/5");
            IRationalNumber fractionD = new RationalNumber("2 6");
            IRationalNumber fractionF = fractionA + fractionB;
            Console.WriteLine("*************");
            Console.WriteLine(IntNumberExtension.ShowMultiplication(fractionA, fractionB));
            Console.WriteLine("*************");
            Console.WriteLine(IntNumberExtension.ShowMultiplication(fractionA, fractionB));
            Console.WriteLine("*************");
            Console.WriteLine(IntNumberExtension.ShowDivision(fractionA, fractionB));
            Console.WriteLine("*************");
            Console.WriteLine(IntNumberExtension.ShowAddition(fractionA, fractionB));
            Console.WriteLine("*************");
            Console.WriteLine(IntNumberExtension.ShowSubtraction(fractionA, fractionB));
            Console.WriteLine("*************");
            Console.WriteLine($"Thanks to the operator overload we can also do this {fractionA} + {fractionB} = {fractionF}");
            Console.WriteLine("*************");





        }


    }
}
