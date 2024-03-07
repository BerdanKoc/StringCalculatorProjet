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
            yield return [4, 2, 7];
            yield return [4, 2, 7, 9];
        }

        [Theory]
        [MemberData(nameof(CasAPlusB))]
        public void APlusB(params int[] parts)
        {
            var input = string.Join(",", parts);

            var result = StringCalculator.Parse(input);

            Assert.Equal(parts.Sum(), result);
        }

        [Fact]
        public void Espaces()
        {
            const string testée = "1 0, 1 0  ";

            var result =
                StringCalculator.Parse(testée);

            var contrôle = StringCalculator.Parse(
                testée.Replace(" ", "")
            );

            Assert.Equal(contrôle, result);
        }

    }
}   