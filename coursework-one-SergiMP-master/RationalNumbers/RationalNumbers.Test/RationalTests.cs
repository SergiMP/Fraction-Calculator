using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RationalNumbers.Test
{
    [TestClass]
    public class RationalTests
    {
        [TestMethod]
        public void Add_two_positive_rational_numbers()
        {   // We expressed positive numbers as a/b or -a/-b //
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 2) + new RationalNumber(2, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 2) + new RationalNumber(2, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber("1/0") + new RationalNumber(2, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0) + new RationalNumber(2, 2));
            Assert.AreEqual(new RationalNumber(7, 6), new RationalNumber(1, 2) + new RationalNumber(2, 3));
            Assert.AreEqual(new RationalNumber(7, 6), new RationalNumber(1, 2).Add(new RationalNumber(2, 3)));
            Assert.AreEqual(new RationalNumber(2, 1), new RationalNumber(1, 1) + new RationalNumber(2, 2));
            Assert.AreEqual(new RationalNumber(2, 1), new RationalNumber(1) + new RationalNumber(-1, -1));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(1) + new RationalNumber(0, 1));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber("1") + new RationalNumber("0/1"));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber("1").Add(new RationalNumber("0/1")));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber("1 1") + new RationalNumber("0 1"));
            Assert.AreEqual(new RationalNumber("7/6"), new RationalNumber("-1/-2") + new RationalNumber("-2/-3"));
            Assert.AreEqual(new RationalNumber("7/6"), new RationalNumber("-1/-2").Add(new RationalNumber("-2/-3")));


        }

        
        [TestMethod]
        public void Add_a_positive_rational_number_and_a_negative_rational_number()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(25, 2) + new RationalNumber(36, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(25, 2) + new RationalNumber("5/0"));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(45, 0) + new RationalNumber(2, 2));
            Assert.AreEqual(new RationalNumber(-1, 6), new RationalNumber(1, 2) + new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(5, 6), new RationalNumber(3, 2).Add(new RationalNumber(-2, 3)));
            Assert.AreEqual(new RationalNumber(5, 6), new RationalNumber(3, 2) + new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(5, 6), new RationalNumber(3, 2) + new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(15, 8), new RationalNumber("-1/8").Add(new RationalNumber("-4 -2")));
            Assert.AreEqual(new RationalNumber(-7, 3), new RationalNumber(-3) + new RationalNumber(2, 3));
            Assert.AreEqual(new RationalNumber(-19,3), new RationalNumber("-7") + new RationalNumber(2, 3));
            Assert.AreEqual(new RationalNumber(15, 8), new RationalNumber("-1/8") + new RationalNumber("-4 -2"));
            Assert.AreEqual(new RationalNumber(15, 8), new RationalNumber("-1/8").Add(new RationalNumber("-4 -2")));
            Assert.AreEqual(new RationalNumber(1,8), new RationalNumber("1/-8") + new RationalNumber("2 8"));
            Assert.AreEqual(new RationalNumber(0,1), new RationalNumber("0/-1") + new RationalNumber("0 1"));

        }


        [TestMethod]
        public void Add_two_negative_rational_numbers()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(-12, 0) + new RationalNumber(10, -2));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(24,-25) + new RationalNumber(-17, 0));
            Assert.AreEqual(new RationalNumber(-7, 6), new RationalNumber(-1, 2) + new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(-11, 15), new RationalNumber(-1, 3) + new RationalNumber(-2, 5));
            Assert.AreEqual(new RationalNumber(-11, 15), new RationalNumber(-1, 3).Add(new RationalNumber(-2, 5)));
            Assert.AreEqual(new RationalNumber(-19, 2), new RationalNumber(9, -2) + new RationalNumber(-15, 3));
            Assert.AreEqual(new RationalNumber(-137, 6), new RationalNumber(-45, 2) + new RationalNumber(-1, 3));
            Assert.AreEqual(new RationalNumber(-264, 35), new RationalNumber(-29, 7) + new RationalNumber(-17, 5));
            Assert.AreEqual(new RationalNumber(-264, 35), new RationalNumber(-29, 7).Add(new RationalNumber(-17, 5)));
            Assert.AreEqual(new RationalNumber(-34, 7), new RationalNumber(-17, 7) + new RationalNumber(17, -7));
            Assert.AreEqual(new RationalNumber(-19,24), new RationalNumber("1/-8") + new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(-19, 24), new RationalNumber("1/-8") + new RationalNumber("4 -6"));
            Assert.AreEqual(new RationalNumber(-19, 24), new RationalNumber("1/-8").Add(new RationalNumber("4 -6")));
            Assert.AreEqual(new RationalNumber(-4, 6), new RationalNumber("0/-1") + new RationalNumber("4 -6"));
           
        }

       
        [TestMethod]
        public void Add_a_rational_number_to_its_additive_inverse()

        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(3, 0) + new RationalNumber(-3, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(5, 25) + new RationalNumber(-5, 0));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 2) + new RationalNumber(-1, 2));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 2).Add( new RationalNumber(-1, 2)));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(3, 4) + new RationalNumber(-3, 4));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(5, 2) + new RationalNumber(-5, 2));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(5, 2).Add(new RationalNumber(-5, 2)));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber("-3/2") + new RationalNumber(3, 2));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber("25 3") + new RationalNumber("-25/3"));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber("-25/8") + new RationalNumber("25/8"));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber("-25/8").Add(new RationalNumber("25/8")));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber("-45/8") + new RationalNumber("45/8"));
        }

        
        [TestMethod]
        public void Subtract_two_positive_rational_numbers()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber("3/0") - new RationalNumber(5, 2));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber("3 0") - new RationalNumber(10, 3));            
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 1) - new RationalNumber(2, 2));
            Assert.AreEqual(new RationalNumber(-853589, 11254), new RationalNumber(18596, 11254) - new RationalNumber(155, 2));
            Assert.AreEqual(new RationalNumber(-853589, 11254), new RationalNumber(18596, 11254).Subtract(new RationalNumber(155, 2)));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber("1") - new RationalNumber("0/1"));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber("1").Subtract(new RationalNumber("0/1")));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1) - new RationalNumber(-1, -1));
            Assert.AreEqual(new RationalNumber(175, -17), new RationalNumber(189, 51) - new RationalNumber(28, 2));
            Assert.AreEqual(new RationalNumber(175, -17), new RationalNumber(189, 51).Subtract(new RationalNumber(28, 2)));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(1) - new RationalNumber(0, 1));
            Assert.AreEqual(new RationalNumber(-1, 6), new RationalNumber(1, 2) - new RationalNumber(2, 3));
            Assert.AreEqual(new RationalNumber(-1, 6), new RationalNumber(1, 2).Subtract(new RationalNumber(2, 3)));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber("-1 -1") - new RationalNumber("-0 -1"));
            Assert.AreEqual(new RationalNumber("-253/126"), new RationalNumber("5/7") - new RationalNumber("98/36"));
            Assert.AreEqual(new RationalNumber("-253/126"), new RationalNumber("5/7").Subtract(new RationalNumber("98/36")));
        }

        
        [TestMethod]
        public void Subtract_a_positive_rational_number_and_a_negative_rational_number()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0) - new RationalNumber(-2, 3));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 2) - new RationalNumber(-2, 0));
            Assert.AreEqual(new RationalNumber(7, 6), new RationalNumber(1, 2) - new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(7, 6), new RationalNumber(1, 2).Subtract(new RationalNumber(-2, 3)));
            Assert.AreEqual(new RationalNumber(20, 7), new RationalNumber(-81, -21) - new RationalNumber(2, 2));
            Assert.AreEqual(new RationalNumber(20, 7), new RationalNumber(-81, -21).Subtract(new RationalNumber(2, 2)));
            Assert.AreEqual(new RationalNumber(2, 1), new RationalNumber("1") - new RationalNumber(-1, 1));
            Assert.AreEqual(new RationalNumber(2, 1), new RationalNumber("1").Subtract(new RationalNumber(-1, 1)));
            Assert.AreEqual(new RationalNumber(-1, 1), new RationalNumber(-1) - new RationalNumber(0, 1));
            Assert.AreEqual(new RationalNumber("433/126"), new RationalNumber("5/7") - new RationalNumber("98/-36"));
            Assert.AreEqual(new RationalNumber("433/126"), new RationalNumber("5/7").Subtract(new RationalNumber("98/-36")));
            Assert.AreEqual(new RationalNumber(-1, 1), new RationalNumber("-1") - new RationalNumber("0/1"));
            Assert.AreEqual(new RationalNumber(135541, -135642), new RationalNumber("-1111 1222") - new RationalNumber("-10 -111"));
            Assert.AreEqual(new RationalNumber(135541, -135642), new RationalNumber("-1111 1222").Subtract(new RationalNumber("-10 -111")));

        }

        
        [TestMethod]
        public void Subtract_two_negative_rational_numbers()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(-1, 0) - new RationalNumber(-2, 3));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, -2) - new RationalNumber(-2, 0));
            Assert.AreEqual(new RationalNumber(1, 6), new RationalNumber(-1, 2) - new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(-20, 7), new RationalNumber(-81, 21) - new RationalNumber(2, -2));
            Assert.AreEqual(new RationalNumber(-20, 7), new RationalNumber(-81, 21).Subtract(new RationalNumber(2, -2)));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber("1") - new RationalNumber(-1, -1));
            Assert.AreEqual(new RationalNumber(9, 1), new RationalNumber(-1).Subtract(new RationalNumber(10, -1)));
            Assert.AreEqual(new RationalNumber(9, 1), new RationalNumber(-1) - new RationalNumber(10, -1));
            Assert.AreEqual(new RationalNumber("253/126"), new RationalNumber("-5/7") - new RationalNumber("98/-36"));
            Assert.AreEqual(new RationalNumber("253/126"), new RationalNumber("-5/7").Subtract(new RationalNumber("98/-36")));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber("1") - new RationalNumber("0/1"));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber("1").Subtract(new RationalNumber("0/1")));
            Assert.AreEqual(new RationalNumber(135541, -135642), new RationalNumber("-1111 1222") - new RationalNumber("-10 -111"));
            Assert.AreEqual(new RationalNumber(135541, -135642), new RationalNumber("-1111 1222").Subtract(new RationalNumber("-10 -111")));
        }

        
        [TestMethod]
        public void Subtract_a_rational_number_from_itself()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0) - new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(2, 0) - new RationalNumber(2, 0));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 2) - new RationalNumber(1, 2));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 2).Subtract(new RationalNumber(1, 2)));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(-1, 2) - new RationalNumber(-1, 2));
            Assert.AreEqual(new RationalNumber("0 1"), new RationalNumber(-81, 21) - new RationalNumber(81, -21));
            Assert.AreEqual(new RationalNumber("0 1"), new RationalNumber(-81, 21).Subtract(new RationalNumber(81, -21)));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber("1/1") - new RationalNumber(-1, -1));
            Assert.AreEqual(new RationalNumber(0,1), new RationalNumber(-10) - new RationalNumber(-10, 1));
            Assert.AreEqual(new RationalNumber("0/1"), new RationalNumber("-98/5") - new RationalNumber("-98/5"));
            Assert.AreEqual(new RationalNumber("0/1"), new RationalNumber("-98/5").Subtract(new RationalNumber("-98/5")));
            Assert.AreEqual(new RationalNumber(1), new RationalNumber("1") - new RationalNumber("0/1"));
            Assert.AreEqual(new RationalNumber("0 1"), new RationalNumber("-1111 1222") - new RationalNumber("-1111/1222"));
            Assert.AreEqual(new RationalNumber("0 1"), new RationalNumber("-1111 1222").Subtract(new RationalNumber("-1111/1222")));
        }

    
        [TestMethod]
        public void Multiply_two_positive_rational_numbers()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 5) * new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(2, 0) * new RationalNumber(2, 10));
            Assert.AreEqual(new RationalNumber(2, 6), new RationalNumber(1, 2) * new RationalNumber(2, 3));
            Assert.AreEqual(new RationalNumber(2, 6), new RationalNumber(1, 2).Multiply( new RationalNumber(2, 3)));
            Assert.AreEqual(new RationalNumber(1, 4), new RationalNumber(1, 2) * new RationalNumber(1, 2));
            Assert.AreEqual(new RationalNumber("45 28"), new RationalNumber(15, 4) * new RationalNumber(3, 7));
            Assert.AreEqual(new RationalNumber("45 28"), new RationalNumber(15, 4).Multiply(new RationalNumber(3, 7)));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber("1/1") * new RationalNumber(-1, -1));
            Assert.AreEqual(new RationalNumber(100, 8), new RationalNumber(10, 8).Multiply(new RationalNumber(10, 1)));
            Assert.AreEqual(new RationalNumber(100, 8), new RationalNumber(10,8) * new RationalNumber(10, 1));
            Assert.AreEqual(new RationalNumber("9604/25"), new RationalNumber("98/5") * new RationalNumber("98/5"));
            Assert.AreEqual(new RationalNumber("9604/25"), new RationalNumber("98/5").Multiply(new RationalNumber("98/5")));
            Assert.AreEqual(new RationalNumber(0,1), new RationalNumber("1") * new RationalNumber("0/1"));
            Assert.AreEqual(new RationalNumber("18 56"), new RationalNumber("6/8") * new RationalNumber("3/7"));
            Assert.AreEqual(new RationalNumber("18 56"), new RationalNumber("6/8").Multiply(new RationalNumber("3/7")));
        }


        [TestMethod]
        public void Multiply_a_negative_rational_number_by_a_positive_rational_number()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 5) * new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(2, 0) * new RationalNumber(-1, 10));
            Assert.AreEqual(new RationalNumber(-20, 15), new RationalNumber(-10, 5) * new RationalNumber(2, 3));
            Assert.AreEqual(new RationalNumber(-20, 15), new RationalNumber(-10, 5).Multiply(new RationalNumber(2, 3)));
            Assert.AreEqual(new RationalNumber(7, -12), new RationalNumber(1, -2) * new RationalNumber(7, 6));
            Assert.AreEqual(new RationalNumber(-9, 10), new RationalNumber(1, 2) * new RationalNumber(-9, 5));
            Assert.AreEqual(new RationalNumber(-9, 10), new RationalNumber(1, 2).Multiply(new RationalNumber(-9, 5)));
            Assert.AreEqual(new RationalNumber("-45 28"), new RationalNumber(15, 4) * new RationalNumber(-3, 7));
            Assert.AreEqual(new RationalNumber(-1, 1), new RationalNumber("1/1") * new RationalNumber(-1, 1));
            Assert.AreEqual(new RationalNumber(-1, 1), new RationalNumber("1/1").Multiply(new RationalNumber(-1, 1)));
            Assert.AreEqual(new RationalNumber(-100, 8), new RationalNumber(10, 8) * new RationalNumber(-10, 1));
            Assert.AreEqual(new RationalNumber("-9604/25"), new RationalNumber("98/5") * new RationalNumber("-98/5"));
            Assert.AreEqual(new RationalNumber("-9604/25"), new RationalNumber("98/5").Multiply(new RationalNumber("-98/5")));
            Assert.AreEqual(new RationalNumber(0, -1), new RationalNumber("-1") * new RationalNumber("0/1"));
            Assert.AreEqual(new RationalNumber("18 -56"), new RationalNumber("6/8") * new RationalNumber("3/-7"));
            Assert.AreEqual(new RationalNumber("18 -56"), new RationalNumber("6/8").Multiply(new RationalNumber("3/-7")));
        }

   
        [TestMethod]
        public void Multiply_two_negative_rational_numbers()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 5) * new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(2, 0).Multiply(new RationalNumber(2, 10)));
            Assert.AreEqual(new RationalNumber(1, 3), new RationalNumber(-1, 2) * new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(20,30), new RationalNumber(-10, 10) * new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber("35 12"), new RationalNumber("-5/2") * new RationalNumber("7 -6"));
            Assert.AreEqual(new RationalNumber("35 12"), new RationalNumber("-5/2").Multiply(new RationalNumber("7 -6")));
            Assert.AreEqual(new RationalNumber(9,10), new RationalNumber("-1/2") * new RationalNumber(-9, 5));
            Assert.AreEqual(new RationalNumber("18 28"), new RationalNumber(6, -4) * new RationalNumber(-3, 7));
            Assert.AreEqual(new RationalNumber("18 28"), new RationalNumber(6, -4).Multiply(new RationalNumber(-3, 7)));
            Assert.AreEqual(new RationalNumber("96/6 "), new RationalNumber("8/-6") * new RationalNumber(-12));
            Assert.AreEqual(new RationalNumber("96/6 "), new RationalNumber("8/-6").Multiply(new RationalNumber(-12)));
            Assert.AreEqual(new RationalNumber(54,7), new RationalNumber(-6, 7) * new RationalNumber(-9, 1));
            Assert.AreEqual(new RationalNumber("2 10"), new RationalNumber("-2 5") * new RationalNumber("1/-2"));
            Assert.AreEqual(new RationalNumber("2 10"), new RationalNumber("-2 5").Multiply(new RationalNumber("1/-2")));
            Assert.AreEqual(new RationalNumber(2230,21), new RationalNumber("-223") * new RationalNumber("10/-21"));
            Assert.AreEqual(new RationalNumber(48,1), new RationalNumber(-8) * new RationalNumber("-6"));
            Assert.AreEqual(new RationalNumber(48, 1), new RationalNumber(-8).Multiply(new RationalNumber("-6")));
        }

        
        [TestMethod]
        public void Multiply_a_rational_number_by_its_reciprocal()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 5) * new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(2, 0) * new RationalNumber(2, 10));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(1, 2) * new RationalNumber(2, 1));
            Assert.AreEqual(new RationalNumber(1), new RationalNumber(-2, 6) * new RationalNumber(-6,2));
            Assert.AreEqual(new RationalNumber("1"), new RationalNumber("-5/2") * new RationalNumber("2 -5"));
            Assert.AreEqual(new RationalNumber("1"), new RationalNumber("-5/2").Multiply(new RationalNumber("2 -5")));
            Assert.AreEqual(new RationalNumber("1/1"), new RationalNumber("-1/2") * new RationalNumber(-2, 1));
            Assert.AreEqual(new RationalNumber("1 1"), new RationalNumber(6, -4) * new RationalNumber(-4, 6));
            Assert.AreEqual(new RationalNumber("1 1"), new RationalNumber(6, -4).Multiply(new RationalNumber(-4, 6)));
            Assert.AreEqual(new RationalNumber(1), new RationalNumber("8/-6") * new RationalNumber(6,-8));
            Assert.AreEqual(new RationalNumber(1,1), new RationalNumber(-6, 7) * new RationalNumber(-7, 6));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(-6, 7).Multiply(new RationalNumber(-7, 6)));
            Assert.AreEqual(new RationalNumber("1 1"), new RationalNumber("-2 5") * new RationalNumber("5/-2"));
            Assert.AreEqual(new RationalNumber("1/1"), new RationalNumber("-223").Multiply(new RationalNumber("1/-223")));
            Assert.AreEqual(new RationalNumber("1/1"), new RationalNumber("-223") * new RationalNumber("1/-223"));
            Assert.AreEqual(new RationalNumber(1), new RationalNumber(-8) * new RationalNumber("1/-8"));
            Assert.AreEqual(new RationalNumber(1), new RationalNumber(-8).Multiply(new RationalNumber("1/-8")));
        }

        [TestMethod]
        public void Multiply_a_rational_number_by_1()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 5) * new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(2, 0) * new RationalNumber(2, 10));
            Assert.AreEqual(new RationalNumber(1,2), new RationalNumber(1, 2) * new RationalNumber(1, 1));
            Assert.AreEqual(new RationalNumber("5/2"), new RationalNumber(5, 2) * new RationalNumber(1));
            Assert.AreEqual(new RationalNumber("5/2"), new RationalNumber(5, 2).Multiply(new RationalNumber(1)));
            Assert.AreEqual(new RationalNumber("-1 3"), new RationalNumber(-2, 6) * new RationalNumber("1"));
            Assert.AreEqual(new RationalNumber(-5,2), new RationalNumber("-5/2") * new RationalNumber("1/1"));
            Assert.AreEqual(new RationalNumber(-5, 2), new RationalNumber("-5/2").Multiply(new RationalNumber("1/1")));
            Assert.AreEqual(new RationalNumber(-1,2), new RationalNumber("-1/2") * new RationalNumber(1,1 ));
            Assert.AreEqual(new RationalNumber("6/-4"), new RationalNumber(6, -4).Multiply(new RationalNumber("1 1")));
            Assert.AreEqual(new RationalNumber("6/-4"), new RationalNumber(6, -4) * new RationalNumber("1 1"));
            Assert.AreEqual(new RationalNumber("-8/6"), new RationalNumber("8/-6") * new RationalNumber(1));
            Assert.AreEqual(new RationalNumber("-8/6"), new RationalNumber("8/-6").Multiply(new RationalNumber(1)));
            Assert.AreEqual(new RationalNumber(-6,7), new RationalNumber(-6, 7) * new RationalNumber(1));
            Assert.AreEqual(new RationalNumber(-2,5), new RationalNumber("-2 5") * new RationalNumber("1 1"));
            Assert.AreEqual(new RationalNumber(-2, 5), new RationalNumber("-2 5").Multiply(new RationalNumber("1 1")));
            Assert.AreEqual(new RationalNumber(-223), new RationalNumber("-223") * new RationalNumber("1/1"));
            Assert.AreEqual(new RationalNumber("-8/1"), new RationalNumber(-8) * new RationalNumber("1 1"));
            Assert.AreEqual(new RationalNumber("-8/1"), new RationalNumber(-8).Multiply(new RationalNumber("1 1")));
        }

      
        [TestMethod]
        public void Multiply_a_rational_number_by_0()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 5) * new RationalNumber(0, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(2, 0) * new RationalNumber(0, 0));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 2) * new RationalNumber(0, 1));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 2).Multiply(new RationalNumber(0, 1)));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber("99") * new RationalNumber("0"));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber("1 2") * new RationalNumber(0, 1));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber("1 2").Multiply(new RationalNumber(0, 1)));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber("-45/8") * new RationalNumber("0/1"));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(-21, 27) * new RationalNumber(0, 1));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(189, 6) * new RationalNumber(0, 1));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(189, 6).Multiply(new RationalNumber(0, 1)));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(187, -22) * new RationalNumber(0, 1));

        }

       
        [TestMethod]
        public void Divide_two_positive_rational_numbers()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 5) / new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(2, 0) / new RationalNumber(2, 10));
            Assert.AreEqual(new RationalNumber(110), new RationalNumber("22") / new RationalNumber("1/5"));
            Assert.AreEqual(new RationalNumber(110), new RationalNumber("22").Divide(new RationalNumber("1/5")));
            Assert.AreEqual(new RationalNumber(5,4), new RationalNumber(5,6) / new RationalNumber(2, 3));
            Assert.AreEqual(new RationalNumber("66/6"), new RationalNumber("22 3").Divide(new RationalNumber(2, 3)));
            Assert.AreEqual(new RationalNumber("66/6"), new RationalNumber("22 3") / new RationalNumber(2, 3));
            Assert.AreEqual(new RationalNumber(10, 16), new RationalNumber(5, 4).Divide(new RationalNumber(4, 2)));
            Assert.AreEqual(new RationalNumber(10,16), new RationalNumber(5,4) / new RationalNumber(4, 2));
            Assert.AreEqual(new RationalNumber("15 28"), new RationalNumber(6, 8).Divide(new RationalNumber(7, 5)));
            Assert.AreEqual(new RationalNumber("15 28"), new RationalNumber(6, 8) / new RationalNumber(7, 5));
            Assert.AreEqual(new RationalNumber(15,4), new RationalNumber(5, 2) / new RationalNumber(2, 3));
            Assert.AreEqual(new RationalNumber(15, 4), new RationalNumber(5, 2).Divide(new RationalNumber(2, 3)));
        }

      
        [TestMethod]
        public void Divide_a_positive_rational_number_by_a_negative_rational_number()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 5) / new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(2, 0) / new RationalNumber(2, 10));
            Assert.AreEqual(new RationalNumber(-3,4), new RationalNumber(1, 2) / new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(-3, 4), new RationalNumber(1, 2).Divide(new RationalNumber(-2, 3)));
            Assert.AreEqual(new RationalNumber("-110"), new RationalNumber("22") / new RationalNumber("-1/5"));
            Assert.AreEqual(new RationalNumber("-5 4"), new RationalNumber(5, 6) / new RationalNumber(2, -3));
            Assert.AreEqual(new RationalNumber("-5 4"), new RationalNumber(5, 6).Divide(new RationalNumber(2, -3)));
            Assert.AreEqual(new RationalNumber(11,24), new RationalNumber("22 3") / new RationalNumber(48, 3));
            Assert.AreEqual(new RationalNumber(-265, 16), new RationalNumber(5, 4).Divide(new RationalNumber(4, -53)));
            Assert.AreEqual(new RationalNumber(-265,16), new RationalNumber(5, 4) / new RationalNumber(4, -53));
            Assert.AreEqual(new RationalNumber("-15 28"), new RationalNumber(6, 8).Divide(new RationalNumber(-7, 5)));
            Assert.AreEqual(new RationalNumber("-15 28"), new RationalNumber(6, 8) / new RationalNumber(-7, 5));
            Assert.AreEqual(new RationalNumber("115/-4"), new RationalNumber(5, 2) / new RationalNumber(2, -23));
            Assert.AreEqual(new RationalNumber("115/-4"), new RationalNumber(5, 2).Divide(new RationalNumber(2, -23)));
        }

        [TestMethod]
        public void Divide_two_negative_rational_numbers()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 5) / new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(2, 0) / new RationalNumber(2, 10));
            Assert.AreEqual(new RationalNumber(3, 4), new RationalNumber(-1, 2) / new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(3, 4), new RationalNumber(-1, 2).Divide(new RationalNumber(-2, 3)));
            Assert.AreEqual(new RationalNumber(10,3), new RationalNumber("-4/2") / new RationalNumber("3/-5"));
            Assert.AreEqual(new RationalNumber(27,35), new RationalNumber(-9,5) / new RationalNumber(-7, 3));
            Assert.AreEqual(new RationalNumber(27, 35), new RationalNumber(-9, 5).Divide(new RationalNumber(-7, 3)));
            Assert.AreEqual(new RationalNumber("16/15"), new RationalNumber("-8 6") / new RationalNumber(-5, 4));
            Assert.AreEqual(new RationalNumber("43 22"), new RationalNumber(-1, 1).Divide(new RationalNumber(-22, 43)));
            Assert.AreEqual(new RationalNumber("43 22"), new RationalNumber(-1, 1) / new RationalNumber(-22, 43));
            Assert.AreEqual(new RationalNumber(35, 36), new RationalNumber("-5 9").Divide(new RationalNumber("-4 7")));
            Assert.AreEqual(new RationalNumber(35,36), new RationalNumber("-5 9") / new RationalNumber("-4 7"));
        }

        [TestMethod]
        public void Divide_a_rational_number_by_1()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 5) / new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(2, 0) / new RationalNumber(2, 10));
            Assert.AreEqual(new RationalNumber(7, 2), new RationalNumber(7, 2) / new RationalNumber(1, 1));
            Assert.AreEqual(new RationalNumber(7, 2), new RationalNumber(7, 2).Divide(new RationalNumber(1, 1)));
            Assert.AreEqual(new RationalNumber(1,2), new RationalNumber(1, 2) / new RationalNumber(1));
            Assert.AreEqual(new RationalNumber("22"), new RationalNumber("22") / new RationalNumber(1));
            Assert.AreEqual(new RationalNumber("22"), new RationalNumber("22").Divide(new RationalNumber(1)));
            Assert.AreEqual(new RationalNumber("5 6"), new RationalNumber(5, 6) / new RationalNumber("1"));
            Assert.AreEqual(new RationalNumber(22, 3), new RationalNumber("22 3") / new RationalNumber("1"));
            Assert.AreEqual(new RationalNumber(22, 3), new RationalNumber("22 3").Divide(new RationalNumber("1")));
            Assert.AreEqual(new RationalNumber(5,4), new RationalNumber(5, 4) / new RationalNumber(1,1));
            Assert.AreEqual(new RationalNumber("6 8"), new RationalNumber(6, 8) / new RationalNumber("1 1"));
            Assert.AreEqual(new RationalNumber("6 8"), new RationalNumber(6, 8).Divide(new RationalNumber("1 1")));
            Assert.AreEqual(new RationalNumber("5/2"), new RationalNumber(5, 2) / new RationalNumber(1,1));
        }


        [TestMethod]
        public void Absolute_value_of_a_positive_rational_number()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0).Abs());
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(2, 0).Abs());
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(1, 2).Abs());
            Assert.AreEqual(new RationalNumber(55, 222), new RationalNumber(55, 222).Abs());
            Assert.AreEqual(new RationalNumber(74, 3), new RationalNumber(74, 3).Abs());
            Assert.AreEqual(new RationalNumber(119, 2), new RationalNumber(119, 2).Abs());
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 1).Abs());
        }

 
        [TestMethod]
        public void Absolute_value_of_a_positive_rational_number_with_negative_numerator_and_denominator()
        {
            Assert.ThrowsException<ArgumentException>(() =>  new RationalNumber(-1, 0).Abs());
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(-2, 0).Abs());
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(-1, -2).Abs());
            Assert.AreEqual(new RationalNumber(55, 72), new RationalNumber(-55, -72).Abs());
            Assert.AreEqual(new RationalNumber(97, 26), new RationalNumber("-97/-26").Abs());
            Assert.AreEqual(new RationalNumber("125 47"), new RationalNumber(-125, -47).Abs());
            Assert.AreEqual(new RationalNumber(97, 26), new RationalNumber(-97, -26).Abs());
            Assert.AreEqual(new RationalNumber(12, 5), new RationalNumber(-12, -5).Abs());
            Assert.AreEqual(new RationalNumber(11111, 22222), new RationalNumber(-11111, -22222).Abs());

        }


        [TestMethod]
        public void Absolute_value_of_a_negative_rational_number()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(new RationalNumber(1, 20), new RationalNumber(-1, 20).Abs());
            Assert.AreEqual(new RationalNumber(15, 7), new RationalNumber(-15, 7).Abs());
            Assert.AreEqual(new RationalNumber(857, 36), new RationalNumber("857 -36").Abs());
            Assert.AreEqual(new RationalNumber(84, 3), new RationalNumber(-84, 3).Abs());
            Assert.AreEqual(new RationalNumber(26, 7), new RationalNumber(-26, 7).Abs());
            Assert.AreEqual(new RationalNumber("2666/7"), new RationalNumber(-2666, 7).Abs());
            Assert.AreEqual(new RationalNumber(125, 36), new RationalNumber(-125, 36).Abs());
            Assert.AreEqual(new RationalNumber(9789898, 454545456), new RationalNumber(9789898, -454545456).Abs());

        }


        [TestMethod]
        public void Absolute_value_of_a_negative_rational_number_with_negative_denominator()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(132132, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1211, 0));
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(1, -2).Abs());
            Assert.AreEqual(new RationalNumber("1 8"), new RationalNumber("1/-8").Abs());
            Assert.AreEqual(new RationalNumber(3, 16), new RationalNumber("3 -16").Abs());
            Assert.AreEqual(new RationalNumber("9/2"), new RationalNumber(9, -2).Abs());
        }

        [TestMethod]
        public void Absolute_value_of_zero()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(new RationalNumber("0/1"), new RationalNumber(0, 1).Abs());
            Assert.AreEqual(new RationalNumber(0, 121321), new RationalNumber(0, -1).Abs());
            Assert.AreEqual(new RationalNumber(0, -1), new RationalNumber("0/-1").Abs());
            Assert.AreEqual(new RationalNumber(0, 12131321), new RationalNumber("0 -1").Abs());
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber("0/-1").Abs());
            Assert.AreEqual(new RationalNumber("0 1"), new RationalNumber("0/-1").Abs());
        }


        [TestMethod]
        public void Raise_a_positive_rational_number_to_a_positive_integer_power()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(new RationalNumber(1, 8), new RationalNumber(1, 2).ExpRational(3));
            Assert.AreEqual(new RationalNumber(16, 1), new RationalNumber("4").ExpRational(2));
            Assert.AreEqual(new RationalNumber(27), new RationalNumber("3/1").ExpRational(3));
            Assert.AreEqual(new RationalNumber(125, 8), new RationalNumber(5, 2).ExpRational(3));
            Assert.AreEqual(new RationalNumber(216, 343), new RationalNumber("6 7").ExpRational(3));
            Assert.AreEqual(new RationalNumber(64, -125), new RationalNumber(4,-5).ExpRational(3));
            Assert.AreEqual(new RationalNumber(216, 343), new RationalNumber("6 7").ExpRational(3));
        }


        [TestMethod]
        public void Raise_a_negative_rational_number_to_a_positive_integer_power()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(new RationalNumber(-1, 8), new RationalNumber(-1, 2).ExpRational(3));
            Assert.AreEqual(new RationalNumber(1, -8), new RationalNumber(-1, 2).ExpRational(3));
            Assert.AreEqual(new RationalNumber(16, 1), new RationalNumber("-4").ExpRational(2));
            Assert.AreEqual(new RationalNumber(-27), new RationalNumber("-3/1").ExpRational(3));
            Assert.AreEqual(new RationalNumber(125, -8), new RationalNumber(-5, 2).ExpRational(3));
            Assert.AreEqual(new RationalNumber(216, -343), new RationalNumber("6 -7").ExpRational(3));
            Assert.AreEqual(new RationalNumber(64, -125), new RationalNumber(4, -5).ExpRational(3));
            Assert.AreEqual(new RationalNumber(-216, 343), new RationalNumber("-6 7").ExpRational(3));
        }

 
        [TestMethod]
        public void Raise_zero_to_an_integer_power()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 1).ExpRational(5));
            Assert.AreEqual(new RationalNumber("0/222222"), new RationalNumber("0/-1").ExpRational(99));
            Assert.AreEqual(new RationalNumber(0, -851), new RationalNumber("0 1251").ExpRational(98654));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 12151).ExpRational(4542154));
            Assert.AreEqual(new RationalNumber(0, -11), new RationalNumber("0/123132").ExpRational(212132));
            Assert.AreEqual(new RationalNumber(0, 121321321), new RationalNumber(0, 1).ExpRational(5));
            Assert.AreEqual(new RationalNumber("0 -23654"), new RationalNumber("0/-1").ExpRational(99));
            Assert.AreEqual(new RationalNumber("0/2"), new RationalNumber("0 1251").ExpRational(98654));
        }


        [TestMethod]
        public void Raise_one_to_an_integer_power()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(1, 1).ExpRational(4));
            Assert.AreEqual(new RationalNumber(122331, 122331), new RationalNumber(1, 1).ExpRational(4));
            Assert.AreEqual(new RationalNumber(-21211521, -21211521), new RationalNumber(987564, 987564).ExpRational(5454644));
            Assert.AreEqual(new RationalNumber("-2544545/-2544545"), new RationalNumber("-123/-123").ExpRational(4));
            Assert.AreEqual(new RationalNumber("1/1"), new RationalNumber("285 285").ExpRational(4454));
            Assert.AreEqual(new RationalNumber("1 1"), new RationalNumber(45,45).ExpRational(554));
            Assert.AreEqual(new RationalNumber(-5551, -5551), new RationalNumber(98,98).ExpRational(33211321));

        }

    
        [TestMethod]
        public void Raise_a_positive_rational_number_to_the_power_of_zero()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(new RationalNumber(1231321, 1231321), new RationalNumber(1, 2).ExpRational(0));
            Assert.AreEqual(new RationalNumber(-5465465, -5465465), new RationalNumber(1321321, 3212312).ExpRational(0));
            Assert.AreEqual(new RationalNumber("2313214/2313214"), new RationalNumber("231321321").ExpRational(0));
            Assert.AreEqual(new RationalNumber(1), new RationalNumber("21321321 3211321").ExpRational(0));
            Assert.AreEqual(new RationalNumber("1"), new RationalNumber(112311, 2).ExpRational(0));
            Assert.AreEqual(new RationalNumber("1/1"), new RationalNumber("23131 231321").ExpRational(0));
            Assert.AreEqual(new RationalNumber("-321321 -321321"), new RationalNumber(1, 2).ExpRational(0));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(1).ExpRational(0));
        }

    
        [TestMethod]
        public void Raise_a_negative_rational_number_to_the_power_of_zero()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(new RationalNumber(1231321, 1231321), new RationalNumber(1, -2).ExpRational(0));
            Assert.AreEqual(new RationalNumber(-5465465, -5465465), new RationalNumber(-1321321, 3212312).ExpRational(0));
            Assert.AreEqual(new RationalNumber("2313214/2313214"), new RationalNumber("-231321321").ExpRational(0));
            Assert.AreEqual(new RationalNumber(1), new RationalNumber("21321321 -3211321").ExpRational(0));
            Assert.AreEqual(new RationalNumber("1"), new RationalNumber(-112311, 2).ExpRational(0));
            Assert.AreEqual(new RationalNumber("1/1"), new RationalNumber("-23131 231321").ExpRational(0));
            Assert.AreEqual(new RationalNumber("-321321 -321321"), new RationalNumber(1,-2).ExpRational(0));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(-1).ExpRational(0));
        }

     
        [TestMethod]
        public void Raise_a_real_number_to_a_positive_rational_number()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(8, 8.ExpReal(new RationalNumber(1)), 0.0001);
            Assert.AreEqual(2, 2.ExpReal(new RationalNumber("1")), 0.0001);
            Assert.AreEqual(1, 1.ExpReal(new RationalNumber("2/3")), 0.0001);
            Assert.AreEqual(2.047672, 6.ExpReal(new RationalNumber("2 5")),0.0001);
            Assert.AreEqual(4, 2.ExpReal(new RationalNumber(6, 3)), 0.0001);
            Assert.AreEqual(2.6918003, 4.ExpReal(new RationalNumber(5, 7)), 0.0001);
            Assert.AreEqual(1.629498, 3.ExpReal(new RationalNumber(4, 9)), 0.0001);
            Assert.AreEqual(32, 4.ExpReal(new RationalNumber(5, 2)), 0.0001);
            Assert.AreEqual(2.508484, 5.ExpReal(new RationalNumber(4, 7)), 0.0001);
           
        }

    
        [TestMethod]
        public void Raise_a_real_number_to_a_negative_rational_number()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(0.33333334, 9.ExpReal(new RationalNumber(-1, 2)), 0.0000001);
            Assert.AreEqual(0.125, 8.ExpReal(new RationalNumber(-1)), 0.0001);
            Assert.AreEqual(0.5, 2.ExpReal(new RationalNumber("-1")), 0.0001);
            Assert.AreEqual(1, 1.ExpReal(new RationalNumber("2/-3")), 0.0001);
            Assert.AreEqual(0.488359, 6.ExpReal(new RationalNumber("-2 5")), 0.0001);
            Assert.AreEqual(0.25, 2.ExpReal(new RationalNumber(6, -3)), 0.0001);
            Assert.AreEqual(0.37149857, 4.ExpReal(new RationalNumber(-5, 7)), 0.0001);
            Assert.AreEqual(0.613685, 3.ExpReal(new RationalNumber("-4/9")), 0.0001);
            Assert.AreEqual(0.03125, 4.ExpReal(new RationalNumber(5, -2)), 0.0001);
            Assert.AreEqual(0.398647, 5.ExpReal(new RationalNumber(-4, 7)), 0.0001);
        }

       
        [TestMethod]
        public void Raise_a_real_number_to_a_zero_rational_number()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(1, 313212.ExpReal(new RationalNumber("0/1")), 0.0000001);
            Assert.AreEqual(1, 12212.ExpReal(new RationalNumber(0, -1)), 0.0000001);
            Assert.AreEqual(1, 11124.ExpReal(new RationalNumber(0, 132132131)), 0.0000001);
            Assert.AreEqual(1, 3333.ExpReal(new RationalNumber("0/-54564556")), 0.0000001);
            Assert.AreEqual(1, 21222.ExpReal(new RationalNumber("0/-549885644")), 0.0000001);
            Assert.AreEqual(1, 2122.ExpReal(new RationalNumber(0, 1)), 0.0000001);
            Assert.AreEqual(1, 5468452.ExpReal(new RationalNumber(0, -54565541)), 0.0000001);
        }

     
        [TestMethod]
        public void Reduce_a_positive_rational_number_to_lowest_terms()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(2, 4).Reduce());
            Assert.AreEqual(new RationalNumber(245, 3), new RationalNumber(245, 3).Reduce());
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(2, 4).Reduce());
            Assert.AreEqual(new RationalNumber("1124331/12143"), new RationalNumber(2248662, 24286).Reduce());
            Assert.AreEqual(new RationalNumber("71591 7159"), new RationalNumber(357955, 35795).Reduce());
            Assert.AreEqual(new RationalNumber(22215, 14), new RationalNumber(22215, 14).Reduce());
            Assert.AreEqual(new RationalNumber(2), new RationalNumber("44/22").Reduce());
        }


        [TestMethod]
        public void Reduce_a_negative_rational_number_to_lowest_terms()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(new RationalNumber(-2, 3), new RationalNumber(-4, 6).Reduce());
            Assert.AreEqual(new RationalNumber(1, -2), new RationalNumber(-2, 4).Reduce());
            Assert.AreEqual(new RationalNumber("-71591 7159"), new RationalNumber(-357955, 35795).Reduce());
            Assert.AreEqual(new RationalNumber(-24555, 33), new RationalNumber(24555, -33).Reduce());
            Assert.AreEqual(new RationalNumber(1, -2), new RationalNumber(-2222, 4444).Reduce());
            Assert.AreEqual(new RationalNumber("-1124331/12143"), new RationalNumber(2248662, -24286).Reduce());
            Assert.AreEqual(new RationalNumber(22215, -14), new RationalNumber(22215, -14).Reduce());
            Assert.AreEqual(new RationalNumber(2), new RationalNumber("4444/2222").Reduce());
        }

     
        [TestMethod]
        public void Reduce_a_rational_number_with_a_negative_denominator_to_lowest_terms()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(new RationalNumber(-1, 3), new RationalNumber(3, -9).Reduce());
            Assert.AreEqual(new RationalNumber("-11193 3113"), new RationalNumber(33579, -9339).Reduce());
            Assert.AreEqual(new RationalNumber(-1221,112), new RationalNumber(2442, -224).Reduce());
            Assert.AreEqual(new RationalNumber("-111"), new RationalNumber(333, -3).Reduce());
            Assert.AreEqual(new RationalNumber(122141,-5465), new RationalNumber("122141/-5465").Reduce());
            Assert.AreEqual(new RationalNumber(-1,3), new RationalNumber(3, -9).Reduce());
            Assert.AreEqual(new RationalNumber(-1211212,133221), new RationalNumber("2422424/-266442").Reduce());
            Assert.AreEqual(new RationalNumber("322121 -213219"), new RationalNumber(322121, -213219).Reduce());
            Assert.AreEqual(new RationalNumber(1,-3), new RationalNumber(33333, -99999).Reduce());
        }

    
        [TestMethod]
        public void Reduce_zero_to_lowest_terms()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 6).Reduce());
            Assert.AreEqual(new RationalNumber(0, 3), new RationalNumber(0, -9).Reduce());
            Assert.AreEqual(new RationalNumber("0 3113"), new RationalNumber(0, -9339).Reduce());
            Assert.AreEqual(new RationalNumber(0, 112), new RationalNumber(0, -224).Reduce());
            Assert.AreEqual(new RationalNumber("0/1"), new RationalNumber(0, -3).Reduce());
            Assert.AreEqual(new RationalNumber(0, -5465), new RationalNumber("0/-5465").Reduce());
            Assert.AreEqual(new RationalNumber(0, 3), new RationalNumber(0, -9).Reduce());
            Assert.AreEqual(new RationalNumber(0, 133221), new RationalNumber("0/-266442").Reduce());
            Assert.AreEqual(new RationalNumber("0 -213219"), new RationalNumber(0, -213219).Reduce());
            Assert.AreEqual(new RationalNumber(0, -3), new RationalNumber(0, -99999).Reduce());
        }
    

    
        [TestMethod]
        public void Reduce_an_integer_to_lowest_terms()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(new RationalNumber("404/37"), new RationalNumber("2424/222").Reduce());
            Assert.AreEqual(new RationalNumber(-111), new RationalNumber("-333 3").Reduce());
            Assert.AreEqual(new RationalNumber("5 1"), new RationalNumber(25, 5).Reduce());
            Assert.AreEqual(new RationalNumber(51,5), new RationalNumber(255,25).Reduce());
            Assert.AreEqual(new RationalNumber(11,-7), new RationalNumber("22 -14").Reduce());
            Assert.AreEqual(new RationalNumber(-15178031, 2803), new RationalNumber(-121424248, 22424).Reduce());
            Assert.AreEqual(new RationalNumber("4041 188"), new RationalNumber("12123 564").Reduce());
            Assert.AreEqual(new RationalNumber(-13,2), new RationalNumber(-78, 12).Reduce());

        }

     
        [TestMethod]
        public void Reduce_one_to_lowest_terms()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(1, 0));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber("-5454 -5454").Reduce());
            Assert.AreEqual(new RationalNumber("1"), new RationalNumber("454/454").Reduce());
            Assert.AreEqual(new RationalNumber("1/1"), new RationalNumber(13321, 13321).Reduce());
            Assert.AreEqual(new RationalNumber(11111111, 11111111), new RationalNumber(-36, -36).Reduce());
            Assert.AreEqual(new RationalNumber(556541, 556541), new RationalNumber("22/22").Reduce());
            Assert.AreEqual(new RationalNumber("65465456 65465456"), new RationalNumber(13, 13).Reduce());
            Assert.AreEqual(new RationalNumber(-1, -1), new RationalNumber(13454554, 13454554).Reduce());
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber("7/7").Reduce());
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber("25 25").Reduce());
        }

        [TestMethod]

        public void Check_Methods_logic()
        {
            IRationalNumber fractionA = new RationalNumber(1, 2);
            IRationalNumber fractionB = new RationalNumber("2");
            Assert.AreEqual("Multiplication: The numerator is equal to 1 * 2 and the denominator is equal to 2 * 1 = 1/1", IntNumberExtension.ShowMultiplication(fractionA, fractionB));
            Assert.AreEqual("Addition: The numerator is equal to 1 * 1 + 2 * 2 and the denominator is equal to 2 * 1 = 5/2", IntNumberExtension.ShowAddition(fractionA, fractionB));
            Assert.AreEqual("Division: The numerator is equal to 1 * 1 and the denominator is equal to 2 * 2 = 1/4", IntNumberExtension.ShowDivision(fractionA, fractionB));
            Assert.AreEqual("Subtraction: The numerator is equal to 1 * 1 - 2 * 2 and the denominator is equal to 2 * 1 = -3/2", IntNumberExtension.ShowSubtraction(fractionA, fractionB));
        
        }
    }
}