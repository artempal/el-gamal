using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElGamal
{
    class Calculate
    {
        static Random rnd = new Random();
        public static int GetNODModul(int val1, int val2) //проверка НОД двух чисел
        {
            while ((val1 != 0) && (val2 != 0))
            {
                if (val1 > val2)
                    val1 %= val2;
                else
                    val2 %= val1;
            }
            return Math.Max(val1, val2);
        }
       static public int Power(int a, int b, int n) // a^b mod n - возведение a в степень b по модулю n
        {
            int tmp = a;
            int sum = tmp;
            for (int i = 1; i < b; i++)
            {
                for (int j = 1; j < a; j++)
                {
                    sum += tmp;
                    if (sum >= n)
                    {
                        sum -= n;
                    }
                }
                tmp = sum;
            }
            return tmp;
        }
        static public int Mul(int a, int b, int n) // a*b mod n - умножение a на b по модулю n
        {
            int sum = 0;
            for (int i = 0; i < b; i++)
            {
                sum += a;
                if (sum >= n)
                {
                    sum -= n;
                }
            }
            return sum;
        }

        static public int GenSessionKey(int p)
        {
            int k = Rand(2, p - 1); //сессионный ключ должен быть от 1 до p-1

            while (GetNODModul(k, p - 1) != 1) // сессионный ключ должен быть взаимно простой с (p-1)
            {
                k = Rand(2, p - 1); //пытаемся сгенерировать правильный
            }
            return k;
        }

        static public int Rand(int start, int end) //генератор
        {
            return rnd.Next(start, end);
        }
    }
}
