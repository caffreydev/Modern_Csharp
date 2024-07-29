public static class NumberExtensions
{
    public static IEnumerable<int> Evens(this IEnumerable<int> numbers) => numbers.Where(x => x % 2 == 0);
    public static IEnumerable<BigInteger> Evens(this IEnumerable<BigInteger> numbers) => numbers.Where(x => x % 2 == 0);
}