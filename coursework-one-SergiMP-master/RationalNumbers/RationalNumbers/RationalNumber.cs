using System;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;


namespace RationalNumbers
{
    /// <summary>
    /// Static class containing several extension methods.
    /// </summary>
    public static class IntNumberExtension
    {
        // We have moved the static class defnition outside RationalNumber class

        /// <summary>
        /// Static overload method of the ExpReal method.   
        /// </summary>
        /// <param name="intNumber">Integer</param>
        /// <param name="r">RationalNumber</param>
        /// <returnsDouble></returns>
        public static double ExpReal(this int intNumber, RationalNumber r)
        {   // Static overload method of the ExpReal method.
            return r.ExpReal(intNumber);
        }

        /// <summary>
        /// Shows the operands and the logic of multiplying two fractions.
        /// </summary>
        /// <param name="a">IrationalNumber</param>
        /// <param name="b">IrationalNumber</param>
        /// <returns>Void</returns>
        public static string ShowMultiplication(this IRationalNumber a,IRationalNumber b)
        {    
            var first = (RationalNumber) a;
            var second = (RationalNumber) b;
            var numerator = $"{first.Numerator} * {second.Numerator}";
            var denominator = $"{first.Denominator} * {second.Denominator}";
            var result = new RationalNumber((first.Numerator * second.Numerator),(first.Denominator  *  second.Denominator));
            return ($"Multiplication: The numerator is equal to {numerator} and the denominator is equal to {denominator}, result is {result}");

        }

        /// <summary>
        /// Shows the operands and the logic of dividing two fractions.
        /// </summary>
        /// <param name="a">IrationalNumber</param>
        /// <param name="b">IrationalNumber</param>
        /// <returns>Void</returns>
        public static string ShowDivision(this IRationalNumber a, IRationalNumber b)
        {
            var first = (RationalNumber)a;
            var second = (RationalNumber)b;
            var numerator = $"{first.Numerator} * {second.Denominator}";
            var denominator = $"{first.Denominator} * {second.Numerator}";
            var result = new RationalNumber((first.Numerator * second.Denominator),first.Denominator * second.Numerator);
            return ($"Division: The numerator is equal to {numerator} and the denominator is equal to {denominator}, result is {result}");

        }

        /// <summary>
        /// Shows the operands and the logic of adding two fractions.
        /// </summary>
        /// <param name="a">IrationalNumber</param>
        /// <param name="b">IrationalNumber</param>
        /// <returns>Void</returns>
        public static string ShowAddition(this IRationalNumber a, IRationalNumber b)
        {
            var first = (RationalNumber)a;
            var second = (RationalNumber)b;
            var numerator = $"{first.Numerator} * {second.Denominator} + {second.Numerator} * {first.Denominator}";
            var denominator = $"{first.Denominator} * {second.Denominator}";
            var result = new RationalNumber((first.Numerator * second.Denominator + second.Numerator * first.Denominator),(first.Denominator * second.Denominator));
            return ($"Addition: The numerator is equal to {numerator} and the denominator is equal to {denominator}, result is {result}");
        }

        /// <summary>
        /// Shows the operands and the logic of subtracting two fractions.
        /// </summary>
        /// <param name="a">IrationalNumber</param>
        /// <param name="b">IrationalNumber</param>
        /// <returns>Void</returns>
        public static string ShowSubtraction(this IRationalNumber a, IRationalNumber b)
        {
            var first = (RationalNumber)a;
            var second = (RationalNumber)b;
            var numerator = $"{first.Numerator} * {second.Denominator} - {second.Numerator} * {first.Denominator}";
            var denominator = $"{first.Denominator} * {second.Denominator}";
            var result = new RationalNumber((first.Numerator * second.Denominator - second.Numerator * first.Denominator),(first.Denominator * second.Denominator));
            return ($"Subtraction: The numerator is equal to {numerator} and the denominator is equal to {denominator}, result is {result}");

        }



    }
    public struct RationalNumber : IRationalNumber
    {

        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        /// <summary>
        /// Private Getters, not really needed but looked nice :)
        /// </summary>
        /// <returns>Int</returns>
        private int GetNumerator() => Numerator;
        private int GetDenominator() => Denominator;



        //The below method is the main constructor. I implemented the logic to reduce the rational number to its
        //lowest form.
        //All the other constructors will call the main one as shown in public constructor(a,b) : this(a,b)
        //This reduces the duplication of code so we would only need to modify the logic in the base constructor, that
        //said I believe it's less readable for less experienced developpers (like yours truly!).


            /// <summary>
            /// Constructor function for rational numbers where parameters are of type int.
            /// </summary>
            /// <param name="numerator">Int</param>
            /// <param name="denominator">Int</param>
        public RationalNumber(int numerator, int denominator)
        {

            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            if (denominator < 0)
            {
                Numerator = -numerator;
                Denominator = -denominator;

            }
            else
            {
                Numerator = numerator;
                Denominator = denominator;
            }


            this.Reduce();

        }

        

        /// <summary>
        /// Constructor function for rational numbers in the form  int a/1.
        /// </summary>
        /// <param name="numerator">Int</param>
        public RationalNumber(int numerator) : this(numerator, 1) { }


        // Constructor function  for string type arguments of type "a/b", "a b" or simply "a"
        // if time allows it I would refactor the code to use the equivalent to super() in Java
        // to simplify the code as I have done with the others.

        /// <summary>
        /// Constructor function  for string type arguments of type "a/b", "a b" or simply "a"
        /// </summary>
        /// <param name="fraction">String</param>

        public RationalNumber(string fraction)

        {
            int numerator;
            int denominator;

            if (fraction.Contains("/"))
            {
                numerator = int.Parse(fraction.Split("/")[0]);
                denominator = int.Parse(fraction.Split("/")[1]);
            }
            else if (fraction.Contains(" "))
            {
                numerator = int.Parse(fraction.Split(" ")[0]);
                denominator = int.Parse(fraction.Split(" ")[1]);

            }
            else
            {
                numerator = int.Parse(fraction);
                denominator = 1;
            }

            if (denominator < 0)
            {
                numerator = numerator * -1;
                denominator = denominator * -1;
            }

            this.Numerator = numerator;
            this.Denominator = denominator;

            this.Reduce();
        }

        /// <summary>
        /// Cast an IRationalNumber into a RationalNumber.
        /// We thought it looks neater although the effect is the same as casting the object directly.
        /// </summary>
        /// <param name="f">IRationalNumber</param>
        /// <returns>RationalNumber</returns>
        private RationalNumber ToRational(IRationalNumber f)
        {  
            return (RationalNumber)f;
        }

        /// <summary>
        /// This is a helper method for Reduce(), to avoid issues with the signs on the denominator we use the Abs() value.
        /// </summary>
        /// <param name="numerator">Int</param>
        /// <param name="denominator">Int</param>
        /// <returns>Int</returns>
        private static int HGD(int numerator, int denominator)
        {   
            numerator = Math.Abs(numerator);
            denominator = Math.Abs(denominator);

            if (denominator == 0)
            {
                return numerator;
            }
            else
            {
                return HGD(denominator, numerator % denominator);
            }
        }

        /// <summary>
        /// We return the current object modified, and not new RationalNumber(a,b) to avoid the infinite loop of new() object creation.
        /// (6/3).Reduce() => (2/1)
        /// </summary>
        /// <returns>RationalNumber</returns>
        public IRationalNumber Reduce()
        {   
            var div = HGD(Numerator, Denominator);
            Numerator = Numerator / div;
            Denominator = Denominator / div;
            return this;

        }





        /** ARITHMETIC AND MATHEMATICAL OPERATIONS METHODS DEFINITIONS BELOW **/
        // Definitions for the static operator overload methods
        public static IRationalNumber operator +(RationalNumber r1, RationalNumber r2) => r1.Add(r2);
        public static IRationalNumber operator -(RationalNumber r1, RationalNumber r2) => r1.Subtract(r2);
        public static IRationalNumber operator *(RationalNumber r1, RationalNumber r2) => r1.Multiply(r2);
        public static IRationalNumber operator /(RationalNumber r1, RationalNumber r2) => r1.Divide(r2);


        /// <summary>
        /// Returns a new object representing the absolute value of the object is initially called upon.
        /// -Obj.Abs() => Obj
        /// </summary>
        /// <returns>IRationalNumber</returns>
        public IRationalNumber Abs()
        {   
            return new RationalNumber(Math.Abs(Numerator), Math.Abs(Denominator));
        }

        /// <summary>
        /// Returns a new object representing the power multiplication of the object is initially called upon.
        /// obj.ExpRational(2) => obj * obj
        /// </summary>
        /// <param name="power">Int</param>
        /// <returns>IRationalNumber</returns>
        public IRationalNumber ExpRational(int power)
        {   
            var a = Convert.ToInt32((Math.Pow(Numerator, power)));
            var b = Convert.ToInt32(Math.Pow(Denominator, power));
            return new RationalNumber(a, b);
        }

        /// <summary>
        /// Returns a Real number representing the decimal version of the object on which the exponentiation operation is called upon
        /// (1/2).ExpReal(1) => 0.5
        /// </summary>
        /// <param name="baseNumber">Int</param>
        /// <returns>Double</returns>
        public double ExpReal(int baseNumber)
        {   
            double exp = (1.0 / Denominator);
            double basenum = Math.Pow(baseNumber, Numerator);
            return Math.Pow(basenum, exp);

        }

        /// <summary>
        /// Returns a new rational number representing the addition of two rational numbers
        /// objA + ObjB =  ObjC
        /// </summary>
        /// <param name="number">IRationalNumber</param>
        /// <returns>IRationalNumber</returns>
        public IRationalNumber Add(IRationalNumber number)
        {    
            var fraction = ToRational(number);
            var numerator = (Numerator * fraction.GetDenominator()) + (fraction.GetNumerator() * Denominator);
            var denominator = (Denominator * fraction.GetDenominator());

            return new RationalNumber(numerator, denominator);
        }


        /// <summary>
        /// Overload method of Add(), this one allows the use of the inline operator "+"
        /// </summary>
        /// <param name="r1">IRationalNumber</param>
        /// <param name="r2">IRationalNumber</param>
        /// <returns>IRationalNumber</returns>
        static IRationalNumber Add(IRationalNumber r1, IRationalNumber r2)
        {      
            return r1.Add(r2);
        }

        /// <summary>
        /// Returns a new rational number representing the subtraction of two rational numbers
        /// objA - ObjB =  ObjC
        /// </summary>
        /// <param name="number">IRationalNumber</param>
        /// <returnsIRationalNumber></returns>
        public IRationalNumber Subtract(IRationalNumber number)
        {    
            var fraction = ToRational(number);
            var numerator = (Numerator * fraction.GetDenominator()) - (fraction.GetNumerator() * Denominator);
            var denominator = (Denominator * fraction.GetDenominator());

            return new RationalNumber(numerator, denominator);
        }

        /// <summary>
        /// Overload method of Substract(), this one allows the use of the inline operator "-"
        /// </summary>
        /// <param name="r1">IRationalNumber</param>
        /// <param name="r2">IRationalNumber</param>
        /// <returns>IRationalNumber</returns>
        static IRationalNumber Subtract(IRationalNumber r1, IRationalNumber r2)
        {  
            return r1.Subtract(r2);
        }

        /// <summary>
        /// Returns a new rational number representing the multiplication of two rational numbers
        /// objA * ObjB =  ObjC
        /// </summary>
        /// <param name="number">IRationalNumber</param>
        /// <returns>IRationalNumber</returns>
        public IRationalNumber Multiply(IRationalNumber number)
        {    
            var fraction = ToRational(number);
            var numerator = Numerator * fraction.GetNumerator();
            var denominator = Denominator * fraction.GetDenominator();

            return new RationalNumber(numerator, denominator);
        }

        /// <summary>
        /// Overload method of Multiply(), this one allows the use of the inline operator "*"
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        static IRationalNumber Multiply(IRationalNumber r1, IRationalNumber r2)
        { 
            return r1.Multiply(r2);
        }

        /// <summary>
        /// Returns a new rational number representing the division of two rational numbers
        /// objA / ObjB =  ObjC
        /// </summary>
        /// <param name="number">IRationalNumber</param>
        /// <returns>IRationalNumber</returns>
        public IRationalNumber Divide(IRationalNumber number)
        {   
            var fraction = ToRational(number);
            var numerator = Numerator * fraction.GetDenominator();
            var denominator = Denominator * fraction.GetNumerator();

            return new RationalNumber(numerator, denominator);
        }

        /// <summary>
        /// Overload method of Divide(), this one allows the use of the inline operator "/"
        /// </summary>
        /// <param name="r1">IRationalNumber</param>
        /// <param name="r2">IRationalNumber</param>
        /// <returns>IRationalNumber</returns>
        static IRationalNumber Divide(IRationalNumber r1, IRationalNumber r2)
        {   
            return r1.Divide(r2);
        }

        /// <summary>
        /// Returns the String version of a RationalNumber object with a "/" in between both
        /// It is automatically call with .Write() or .WriteLine()
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {   
            return $"{this.Numerator}/{this.Denominator}";
        }

        /// <summary>
        /// Returns true if the values and the hashCode of two objects are the same, false otherwise
        /// ObjA = 2/2 , ObjB = 2/2
        /// (ObjA).Equals(ObjB) => true
        ///  Using == the above would had returned false, since the references of the objects are different.
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {   
            if (obj == null)
            {
                return false;
            }
            if (GetType() != obj.GetType())
            {
                return false;
            }
            var fraction = (RationalNumber)obj;
            var numerators = Numerator == fraction.GetNumerator();
            var denominators = Denominator == fraction.GetDenominator();
            return numerators & denominators;
        }

      
        /// <summary>
        ///  We simply changed the GetHashCode() method to reference the current object.
        ///  ref https://docs.microsoft.com/en-gb/archive/blogs/ericlippert/guidelines-and-rules-for-gethashcode
        /// </summary>
        /// <returns>Int</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();

        }

       
    }
}
