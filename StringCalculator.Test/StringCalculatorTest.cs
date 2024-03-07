namespace StringCalculator.Test
{
    public class StringCalculatorTest
    {
        public static IEnumerable<object[]> CasAPlusB()
        {
            yield return [0, 0];
            yield return [1, 0];
            yield return [0, 1];
            yield return [2, 0];
            yield return [0, 2];
        }

        [Theory]
        [MemberData(nameof(CasAPlusB))]
        public void APlusB(int[] parts)
        {
            var input = string.Join(",", parts);

            var result = StringCalculator.Parse();

            Assert.Equal(parts.Sum(), result);
        }

        [Fact]
        public void UnPlusZero()
        {
            var parts = new int[] { 0, 1 };

            var input = string.Join(",", parts);

            var result = StringCalculator.Parse();

            Assert.Equal(parts.Sum(), result);
        }
        [Fact]
        public void DeuxPlusZero()
        {
            var parts = new int[] { 2, 0 };

            var input = string.Join(",", parts);

            var result = StringCalculator.Parse();

            Assert.Equal(parts.Sum(), result);
        }
    }
}   