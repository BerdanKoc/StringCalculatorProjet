namespace StringCalculator
{
    public class StringCalculator
    {
        public static int Parse()
        {
            var input = "2,0";
            var parts = input.Split(',');
            return int.Parse(parts.First()) + int.Parse(parts.Last());
        }
    }
}
