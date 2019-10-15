using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кількість елементів масиву - ");
            int N = Convert.ToInt32(Console.ReadLine());
            int index;
            double[] Arr = new double[N];
            Random r = new Random();
            for (int i = 0; i < N; i++)
            {
                Arr[i] = (r.Next(-1000, 1001)) / 10.0;
                Console.Write(Arr[i] + "  ");
            }
            Console.Write("\n");
            Console.WriteLine("сумма: {0}", sumless0(N, Arr));
            Console.WriteLine("MAX: {0} Індекс: {1}", maxandindex(N, Arr, out index), index);
            Console.WriteLine("MAX за модулем: {0}", maxabs(N, Arr));
            Console.WriteLine("Сума індексів: {0}", sumindex(N, Arr));
            Console.WriteLine("Кількість цілих чисел: {0}", countindex(N, Arr));
            Console.ReadKey();
        }
        static double sumless0(int N, double[] Arr)
        {
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                if (Arr[i] < 0)
                {
                    sum += Arr[i];
                }
            }
            return sum;
        }
        static double maxandindex(int N, double[] Arr, out int index)
        {
            double max = -100;
            index = 0;
            for (int i = 0; i < N; i++)
            {
                if (Arr[i] > max)
                {
                    max = Arr[i];
                    index = i;
                }
            }
            return max;
        }
        static double maxabs(int N, double[] Arr)
        {
            double maxabs = 0;
            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(Arr[i]) > Math.Abs(maxabs))
                {
                    maxabs = Arr[i];
                }
            }
            return maxabs;
        }
        static int sumindex(int N, double[] Arr)
        {
            int sumindex = 0;
            for (int i = 0; i < N; i++)
            {
                if (Arr[i] > 0)
                {
                    sumindex += i;
                }
            }
            return sumindex;
        }
        static int countindex(int N, double[] Arr)
        {
            int indexcount = 0;
            for (int i = 0; i < N; i++)
            {
                if (Arr[i] % 1 == 0)
                {
                    indexcount++;
                }
            }
            return indexcount;
        }
    }
}
