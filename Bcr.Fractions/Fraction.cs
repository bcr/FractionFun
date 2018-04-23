using System;

namespace Bcr.Fractions
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public uint Denominator { get; set; }

        public static Fraction FromString(string mixedFractionString)
        {
            var numeratorDenominator = mixedFractionString.Split('/');
            return new Fraction { Numerator = int.Parse(numeratorDenominator[0]), Denominator = uint.Parse(numeratorDenominator[1])};
        }
    }
}
