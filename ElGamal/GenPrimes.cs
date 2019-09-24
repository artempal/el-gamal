using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElGamal
{
    class GenPrimes
    {
        public static List<int> get_primes(int start, int end)
        {
            // is_prime[i] == true, если i -- простое число
            bool[] is_prime = new bool[end + 1];
            for (int i = start; i <= end; ++i) is_prime[i] = true;
            // primes будет содержать все простые числа на отрезке от 1 до n
            List<int> primes = new List<int>();
            // Алгоритм Решето Эратосфена
            for (int i = start; i <= end; ++i)
                if (is_prime[i])
                {
                    primes.Add(i);
                    if (i * i <= end)
                        for (int j = i * i; j <= end; j += i)
                            is_prime[j] = false;
                }
            return primes;
        }

        public static int Gen()
        {
            List<int> primes = get_primes(200,4000); // генерирует 3801 простых числа
            Random rnd = new Random();
            int value = rnd.Next(0,3800);
            return primes[value];
        }
    }
}
