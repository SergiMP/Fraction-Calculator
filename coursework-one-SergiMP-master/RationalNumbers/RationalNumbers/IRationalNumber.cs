using System;
using System.Net.Sockets;

namespace RationalNumbers
{
    public interface IRationalNumber
    {
        IRationalNumber Add(IRationalNumber number);
        IRationalNumber Subtract(IRationalNumber number);
        IRationalNumber Multiply(IRationalNumber number);
        IRationalNumber Divide(IRationalNumber number);
        IRationalNumber Abs();
        IRationalNumber ExpRational(int power);
        double ExpReal(int baseNumber);
        bool Equals(object obj);

        // Anything else you need to add? => I have added the overload operators since I believe for most users it is more natural
        // to use the infix operator than the method call i.e  a + b instead of a.Add(b), and above all doesn't conflict with the 
        // methods requested on the main interface.
        // That said I have only added it since in the course we are working with C# 8.0, since static members on an interface only
        // work from this version.

        public static IRationalNumber operator +(IRationalNumber r1, IRationalNumber r2) => r1.Add(r2);
        public static IRationalNumber operator -(IRationalNumber r1, IRationalNumber r2) => r1.Subtract(r2);
        public static IRationalNumber operator *(IRationalNumber r1, IRationalNumber r2) => r1.Multiply(r2);
        public static IRationalNumber operator /(IRationalNumber r1, IRationalNumber r2) => r1.Divide(r2);


        


    }
}
