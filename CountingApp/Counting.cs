using System.Numerics;

namespace CountingApp
{
    /// <summary>
    /// This class allows a user to solve counting problems from the command
    /// line. Arguments are integer, "choose" or "permute", integer.
    /// 
    /// First integer is the number of items in a set, and the second integer
    /// is the number of items being chosen.
    /// 
    /// Example: 6 choose 3 will output 20
    /// Because there are 30 different ways to choose 3 items from a set of 
    /// 6 (ignoring order). 
    /// 
    /// Permute calculates this with order considered.
    /// 6 permute 3 will output 120
    /// </summary>
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

        /// <summary>
        /// Calculates the permutations
        /// </summary>
        /// <param name="n"></param>
        /// <param name="r"></param>
        /// <returns></returns>
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