namespace StringCalculator
{
    public class StringCalculator
    {
        public static int Parse(string input)
        {
            var parts = input.Split(',');
            return parts.Select(int.Parse).Sum();
        }
    }
}
