using System;

namespace Home_work_4
{
    #region (Class Massive and options)
    class Array20
    {
        int[] a;
        public Array20(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        public int D3
        {
            get
            {
                int min = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] % 3 == 0) min++;
                return min;
            }
        }
        public int Summ
        {
            get
            {
                int min = a[0];
                for (int i = 0; i < a.Length; i++)
                    min = min + a[i];
                return min;
            }
        }
        public int SummA
        {
            get
            {
                int min = a[0];
                for (int i = 0; i < a.Length; i++)
                    min = min + Math.Abs(a[i]);
                return min;
            }
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }


        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }

    }
    #endregion
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int razmer = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите минимальное число");
            int nachalo = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальное число");
            int konetc = int.Parse(Console.ReadLine());
            Array20 a = new Array20(razmer, nachalo, konetc);
            Console.WriteLine();
            Console.WriteLine("Сгенерирован случайный массив");
            Console.WriteLine(a.ToString());
            Console.WriteLine();
            Console.WriteLine($"в массиве {a.D3} чисел делятся на 3");
            Console.WriteLine();
            Console.WriteLine($"максимальное число в массиве {a.Max}");
            Console.WriteLine();
            Console.WriteLine($"{a.Summ} Сумма всех элементов массива");
            Console.WriteLine();
            Console.WriteLine($"{a.SummA} Сумма всех элементов массива по модулю");
            Console.ReadKey();

        }
    }
}
