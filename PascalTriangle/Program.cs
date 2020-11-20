using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTriangle();
            Console.ReadKey();
        }

        static void BinaryTriangle()
        {
            Console.WriteLine("Введите номер функции");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Номер функции: " + number);
            string dn = Convert.ToString(number, 2);
            Console.WriteLine("Номер функции в двоичной системе счисления: " + dn);
            Console.WriteLine();
            char[] dnumber = dn.ToCharArray();

            //int n = dnumber.Length;
            //string spaces = null;
            //for (int u = 0; u < n; u++)
            //{
            //    spaces += " ";
            //}

            int count = dnumber.Length;

            //int aLentgh = 0;
            //for (int k = 1; k <= n; k++)
            //{
            //    aLentgh += k;
            //}

            bool[] arrbool = new bool[/*aLentgh*/ 40];

            for (int m = 0; m < dnumber.Length; m++)
            {
                //if (dnumber[m] == '1')
                //{
                //    arrbool[m] = true;
                //}
                //else arrbool[m] = false;

                arrbool[m] = dnumber[m] == '1' ? true : false;

                //_= dnumber[m] == 1 ? arrbool[m] = true : arrbool[m] = false;
            }

            string str = null;

            for (int t = 0; t < dnumber.Length; t++)
            {
                str += (arrbool[t] == true ? "1" : "0") + " ";

            }
            Console.WriteLine(str);
            str = null;

            for (int i = dnumber.Length; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    arrbool[count] = arrbool[count - i] ^ arrbool[count - i + 1];
                    str += (arrbool[count] == true ? "1" : "0") + " ";
                    count++;
                }
                Console.WriteLine(str);
                str = null;
            }

        }
    }
}

