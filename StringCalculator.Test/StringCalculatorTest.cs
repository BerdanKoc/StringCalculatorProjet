namespace StringCalculator.Test
{
    public class StringCalculatorTest
    {
        [Fact]
        public void APlusB()
        {
            var parts = new int[] { 0, 1 };

            var input = string.Join(",", parts);

            var result = StringCalculator.Parse();

            Assert.Equal(parts.Sum(), result);
        }
    }
}   