namespace RationalNumbers
{
    public struct ReducedNumber : IRationalNumber
    {
        public IRationalNumber Reduce()
        {
            //var divisor = HGD(Numerator, Denominator);
            
            return new RationalNumber(Numerator, Denominator);
            
        }

        
    }
}