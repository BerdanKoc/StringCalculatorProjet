namespace StringCalculator
{
    public class StringCalculator
    {
        public static int Parse()
        {
            var input = "0,1";
            var parts = input.Split(',');
            return int.Parse(parts.First()) + int.Parse(parts.Last());
        }
    }
}
