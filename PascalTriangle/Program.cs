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
            int number = Convert.ToInt32(Console.ReadLine()); //number - номер функции
            Console.WriteLine("Номер функции: " + number);
            string dn = Convert.ToString(number, 2); //Перевод номера функции в двоичную систему (в строку) - переменная dn
            Console.WriteLine("Номер функции в двоичной системе счисления: " + dn);
            Console.WriteLine();
            char[] dnumber = dn.ToCharArray();//Создание символьного массива dnumber из строковой переменной dn 

            //int n = dnumber.Length;
            //string spaces = null;
            //for (int u = 0; u < n; u++)
            //{
            //    spaces += " ";
            //}

            int count = dnumber.Length;//count - глобальный счётчик, присваиваем значение длины массива dnumber 

            //int aLentgh = 0;
            //for (int k = 1; k <= n; k++)
            //{
            //    aLentgh += k;
            //}

            bool[] arrbool = new bool[/*aLentgh*/ 40];//Создаём логический массив arrbool, в котором будут все элементы треугольника Паскаля

            for (int m = 0; m < dnumber.Length; m++)//Цикл m, который присваевает значения символьного массива dnumber соответсвующим элементам логического массива arrbool
            {
                //if (dnumber[m] == '1')
                //{
                //    arrbool[m] = true;
                //}
                //else arrbool[m] = false;

                arrbool[m] = dnumber[m] == '1' ? true : false;//Соответсвующему элементу массива arrbool присваивается соответствующее значение массива dnumber (если элемент массива dnumber равен 1, то присваивается значение True 

                //_= dnumber[m] == 1 ? arrbool[m] = true : arrbool[m] = false;
            }

            string str = null;//Создаём  пустую строковую переменную

            for (int t = 0; t < dnumber.Length; t++)//Цикл t, в котором строковая переменная str заполняется соответствующими значениями строки треугольника Паскаля (из элементов массива arrbool)
            {
                str += (arrbool[t] == true ? "1" : "0") + " ";

            }
            Console.WriteLine(str);//Вывод первой строки треугольника Паскаля
            str = null;//Обнуляем строковую переменную str

            for (int i = dnumber.Length; i > 0; i--)//Цикл i, в котором заполняются последующие строки треугольника Паскаля
            {
                for (int j = 0; j < i - 1; j++)//Цикл j, в котром строковая переменная str заполняется следующими за прошлыми значениями строки треугольника Паскаля (из элементов массива arrbool)
                {
                    arrbool[count] = arrbool[count - i] ^ arrbool[count - i + 1];//Присваиваем следующему элементу треугольника Паскаля значение равное сложению по модулю два двух вышестоящих элементов треугольника Паскаля
                    str += (arrbool[count] == true ? "1" : "0") + " ";
                    count++;//счетчик увеличивается на 1, чтобы перейти на следующий элемент массива arrbool
                }
                Console.WriteLine(str);//Вывод следующей строки треугольника Паскаля
                str = null;//Обнуляем строковую переменную str
            }

        }
    }
}

