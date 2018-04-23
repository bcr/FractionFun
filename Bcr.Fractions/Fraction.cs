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
            return $"{Numerator}/{Denominator}";
        }
    }
}
