namespace ConsoleApp6
{
    class Fraction
    {
        int numerator;
        int denominator;

        public int Numerator { get => numerator; set => numerator = value; }
        public int Denominator { get => denominator; set => denominator = value == 0 ? 1 : value; }

        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }

        public Fraction(int numerator) : this()
        {
            Numerator = numerator;

        }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public Fraction Reverse()
        {
            //return $"{denominator}/{numerator}";
            return new Fraction(denominator, numerator);
        }

        public static Fraction Sum(Fraction fr1, Fraction fr2)
        {
            int num = fr1.Numerator * fr2.Denominator + fr2.Numerator * fr1.denominator;
            int denom = fr1.Denominator * fr2.Denominator;
            return new Fraction(num, denom);
        }

        public static Fraction Multi(Fraction fr1, Fraction fr2)
        {
            int num = fr1.Numerator * fr2.Numerator;
            int denom = fr1.Denominator * fr2.Denominator;
            return new Fraction(num, denom);
        }

    }
}
