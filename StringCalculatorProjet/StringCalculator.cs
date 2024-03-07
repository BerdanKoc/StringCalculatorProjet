namespace StringCalculator
{
    public class StringCalculator
    {
        public static int Parse(string input)
        {
            input = input.Replace(" ", "");
            var parts = input.Split(',');
            return parts.Select(int.Parse).Sum();
        }
    }
}
