namespace ConsoleApp6
{
    class Fraction
    {
        int wholePart = 0;
        int numerator;
        int denominator;

        public int Numerator { get => numerator; set => numerator = value; }
        public int Denominator { get => denominator; set => denominator = value == 0 ? 1 : value; }

        /*
        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }

        public Fraction(int numerator) : this()
        {
            Numerator = numerator;
        }
        */

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction(int wholePart, int numerator, int denominator):this(numerator, denominator)
        {
            this.wholePart = wholePart;
        }

        public override string ToString()
        {
            return $"{((wholePart == 0)?"":wholePart+"/")}{numerator}/{denominator}";
        }

        public Fraction Reverse()
        {
            DeNormal();
            return new Fraction(denominator, numerator);
        }

        public static Fraction Sum(Fraction fr1, Fraction fr2)
        {
            fr1.DeNormal();
            fr2.DeNormal();

            int num = fr1.Numerator * fr2.Denominator + fr2.Numerator * fr1.denominator;
            int denom = fr1.Denominator * fr2.Denominator;
            return new Fraction(num, denom);
        }

        public static Fraction Multi(Fraction fr1, Fraction fr2)
        {
            fr1.DeNormal();
            fr2.DeNormal();

            int num = fr1.Numerator * fr2.Numerator;
            int denom = fr1.Denominator * fr2.Denominator;
            return new Fraction(num, denom);
        }

        public Fraction Reduction() {
            DeNormal();

            int min = Numerator == Denominator ? Numerator : 
                            (Numerator < Denominator) ? Numerator : Denominator;

            for (int i = min; i > 1 && Numerator > 1 && Denominator > 1 ; i--)
			{
                if (Numerator % i == 0 && Denominator % i == 0){
                    Numerator /= i;
                    Denominator /= i;
                }                                                              
			}

            return new Fraction(Numerator, Denominator);
        }

        public Fraction Normal() {
            wholePart = (int)Numerator/Denominator;
            Numerator = Numerator - wholePart*Denominator;
            return this;
        }

        public Fraction DeNormal() {
            if (wholePart != 0) {
                Numerator = wholePart*Denominator+Numerator;
                wholePart = 0;
            }
            return this;
        }

    }
}
