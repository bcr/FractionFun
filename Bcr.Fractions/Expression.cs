namespace Bcr.Fractions
{
    public class Expression
    {
        public static string Evaluate(string expression)
        {
            var parsedExpression = System.Text.RegularExpressions.Regex.Split(expression, @"\s+");

            // Expression syntax is:
            //
            // ? 1/2 * 3_3/4
            //
            // So [1] is term 1, [2] is operator and [3] is term 2

            var term1 = Fraction.FromString(parsedExpression[1]);
            var _operator = parsedExpression[2];
            var term2 = Fraction.FromString(parsedExpression[3]);

            Fraction result = null;

            switch (_operator)
            {
                case "*":
                    result = term1 * term2;
                    break;

                case "+":
                    result = term1 + term2;
                    break;

                case "-":
                    result = term1 - term2;
                    break;

                case "/":
                    result = term1 / term2;
                    break;
            }

            result.LowestTermify();

            return $"= {result}";
        }
    }
}
