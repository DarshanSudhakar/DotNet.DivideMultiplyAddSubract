namespace Operation
{
    public class BasicOperation
    {
        public int Add(int augend, int addend) 
        { 
            var sum = augend + addend;
            return sum;
        }

        public int Sub(int minuend, int subtrahend)
        {
            var difference = minuend - subtrahend;
            return difference;
        }

        public int Multiply(int multiplicand, int multiplier)
        {
            var product = multiplicand * multiplier;
            return product;
        }

        public int Divide(int dividend, int divisor)
        {
            var quotient = dividend / divisor;
            return quotient;
        }
    }
}