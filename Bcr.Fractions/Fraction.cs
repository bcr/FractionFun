using System;

namespace Bcr.Fractions
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public uint Denominator { get; set; }

        public static Fraction FromString(string mixedFractionString)
        {
            int whole;
            int numerator;
            uint denominator;

            var wholeFraction = mixedFractionString.Split('_');

            if (wholeFraction.Length > 1)
            {
                whole = int.Parse(wholeFraction[0]);
                mixedFractionString = wholeFraction[1];
            }
            else
            {
                whole = 0;
            }

            var numeratorDenominator = mixedFractionString.Split('/');

            numerator = int.Parse(numeratorDenominator[0]);
            if (whole < 0)
            {
                numerator = -numerator;
            }

            if (numeratorDenominator.Length > 1)
            {
                denominator = uint.Parse(numeratorDenominator[1]);
            }
            else
            {
                whole = numerator;
                numerator = 0;
                denominator = 1;
            }

            numerator += (whole * (int) denominator);

            return new Fraction { Numerator = numerator, Denominator = denominator};
        }

        public override int GetHashCode()
        {
            return Numerator.GetHashCode() + Denominator.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var otherFraction = obj as Fraction;

            return (Numerator == otherFraction.Numerator) && (Denominator == otherFraction.Denominator);
        }

        public override string ToString()
        {
            if (Numerator > Denominator)
            {
                var whole = Numerator/Denominator;
                var numerator = Numerator - (whole * Denominator);

                if (numerator > 0)
                {
                    return $"{whole}_{numerator}/{Denominator}";
                }
                else
                {
                    return $"{whole}";
                }
            }
            else
            {
                return $"{Numerator}/{Denominator}";
            }
        }

        // https://stackoverflow.com/questions/18541832/c-sharp-find-the-greatest-common-divisor
        private static int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }

        public void LowestTermify()
        {
            var divisor = gcd(Numerator, (int) Denominator);
            Numerator /= divisor;
            Denominator /= (uint) divisor;
        }

        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/overloadable-operators

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction { Numerator = f1.Numerator * f2.Numerator, Denominator = f1.Denominator * f2.Denominator };
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return new Fraction { Numerator = f1.Numerator * (int) f2.Denominator, Denominator = (uint) (f2.Numerator * (int) f1.Denominator) };
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction { Numerator = (f1.Numerator * (int) f2.Denominator) + (f2.Numerator * (int) f1.Denominator), Denominator = f1.Denominator * f2.Denominator };
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction { Numerator = (f1.Numerator * (int) f2.Denominator) - (f2.Numerator * (int) f1.Denominator), Denominator = f1.Denominator * f2.Denominator };
        }
    }
}
