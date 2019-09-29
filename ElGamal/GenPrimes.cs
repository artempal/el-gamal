using System;

namespace ElGamal
{
    class GenPrimes
    {
        static int start = 1000; //начало генерации
        static int end = 2000; //конец генерации
        static bool IsPrime(long n) // это простое число?
        {
            for (long i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        public static int Gen() // генератор простых чисел
        {
            bool prime = false;
            int number = 0;
            while (prime != true) // пока число не станет простым
            {
                number = Calculate.Rand(start, end); //генерируем число
                prime = IsPrime(number); // проверка на простоту
            }
            
            return number;
        }
    }
}
