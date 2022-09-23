using System.Numerics;

namespace CountingApp
{
    internal class Counting
    {
        static void Main(string[] args)
        {
            // check for integers and save them for later.
            if (!BigInteger.TryParse(args[0], out BigInteger n) || !BigInteger.TryParse(args[2], out BigInteger r))
                throw new ArgumentException("First and last argument must be integers.");


            // set up result and Argument type
            BigInteger result;
            string countType = args[1].ToLower();

            // Call method corresponding to argument or throw error
            if (countType == "permute")
                result = Permute(n, r);
            else if (countType == "choose")
                result = Choose(n, r);
            else throw new ArgumentException("Argument must be either 'choose' or 'permute'.");

            // print result
            Console.WriteLine();

            Console.WriteLine($"\t\tNumber of ways to {countType} {r} " +
                $"items from a set of {n} items:");
            Console.WriteLine();
            Console.WriteLine("\t\t" + result.ToString());
            Console.Read();
        }

        private static BigInteger Permute(BigInteger n, BigInteger r)
        {
            return Factorial(n) / Factorial(n - r);
        }

        private static BigInteger Choose(BigInteger n, BigInteger r)
        {
            return Permute(n, r) / Factorial(r);
        }

        private static BigInteger Factorial(BigInteger num)
        {
            if (num <= 1)
                return 1;
            else return num * Factorial(num - 1);
        }

    }
}