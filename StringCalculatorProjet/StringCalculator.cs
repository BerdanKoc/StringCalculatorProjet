namespace StringCalculator
{
    public class StringCalculator
    {
        public static int Parse(string input)
        {
            input = input.Replace(" ", "");
            var parts = input.Split(',');

            // Vérifier les nombres négatifs
            var nombresNegatifs = parts.Where(p => p.StartsWith("-")).ToList();
            if (nombresNegatifs.Any())
            {
                var nombresNegatifsAvecPositions = nombresNegatifs.Select((n, i) => $"{n} à la position {input.IndexOf(n) + 1}");
                throw new Exception($"Les nombres négatifs ne sont pas autorisés : {string.Join(", ", nombresNegatifsAvecPositions)}");
            }

            return parts.Select(int.Parse).Sum();
        }
    }
}
