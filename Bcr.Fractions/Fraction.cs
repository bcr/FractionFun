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

            denominator = uint.Parse(numeratorDenominator[1]);
            numerator = (whole * (int) denominator) + int.Parse(numeratorDenominator[0]);

            return new Fraction { Numerator = numerator, Denominator = denominator};
        }
    }
}
