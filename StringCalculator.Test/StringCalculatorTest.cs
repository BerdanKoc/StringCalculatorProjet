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

        [Fact]
        public void NombresNegatifs_LanceExceptionAvecNombresEtPositionsCas1()
        {
            const string input = "-1,2,-3,4";

            var exception = Assert.Throws<Exception>(() => StringCalculator.Parse(input));

            Assert.Contains("-1 à la position 1", exception.Message);
            Assert.Contains("-3 à la position 6", exception.Message);
        }

        public static IEnumerable<object[]> CasNombresNegatifs()
        {
            yield return new object[] { "-1,2,-3,4", new string[] { "-1", "-3" }, new int[] { 1, 6 } };
            yield return new object[] { "-5,-8,3,-10,2", new string[] { "-5", "-8", "-10" }, new int[] { 1, 4, 9 } };
        }

        [Theory]
        [MemberData(nameof(CasNombresNegatifs))]
        public void NombresNegatifs_LanceExceptionAvecNombresEtPositions(string input, string[] nombresNegatifs, int[] positions)
        {
            var exception = Assert.Throws<Exception>(() => StringCalculator.Parse(input));

            foreach (var nombre in nombresNegatifs)
            {
                Assert.Contains(nombre, exception.Message);
            }

            foreach (var position in positions)
            {
                Assert.Contains(position.ToString(), exception.Message);
            }
        }


    }
}   