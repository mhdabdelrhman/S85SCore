using System;

namespace S85S.Core.Extensions
{
    public static class IntExtensions
    {
        public static bool IsZero(this int i)
        {
            return i == 0;
        }

        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }

        public static bool IsOdd(this int i)
        {
            return !i.IsEven();
        }

        public static bool IsPrime(this int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
