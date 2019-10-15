using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кількість елементів масиву - ");
            int N = Convert.ToInt32(Console.ReadLine());
            double[] Arr = new double[N];
            Random r = new Random();
            for (int i = 0; i < N; i++)
            {
                Arr[i] = (r.Next(-1000, 1001)) / 10.0;
                Console.Write(Arr[i] + "  ");
            }
            Console.Write("\n");
            Console.WriteLine("Множення після мінімального: {0}", multiple(N, Arr));
            Console.WriteLine("Дивне додавання: {0}", StrangeSum(N, Arr));
            Console.WriteLine("Дивне додавання2: {0}", StrangeSum2(N, Arr));
            Console.WriteLine("Дивне множення: {0}", maxabsminabs(N, Arr));
        }
        static double multiple (int N, double[] Arr)
        {
            double multiple = 1;
            double min = 0;
            int index=0;
            for (int i = 0;i < N; i++)
            {
                if (Arr[i]< min)
                {
                    min = Arr[i];
                    index = i+1;
                }
            }
            if (index >= N)
            {
                return 0;
            }
            else
            {
                for (; index < N; index++)
                {
                        multiple *= Arr[index];
                }
            }
            return multiple;
        }
        static double StrangeSum(int N, double[] Arr)
        {
            double StrangeSum = 0;
            int indexmin = 0;
            int k = 0;
            int indexmax = N;
            for (int i = 0; i < N; i++)
            {
                if (Arr[i] < 0)
                {
                    indexmin = i + 1;
                    break;
                }
            }
            for (int i = 0; i < N; i++)
            {
                if (Arr[i] > 0)
                {
                    k++;
                }
                if (k==2)
                {
                    indexmax = i;
                    break;
                }
            }
            if (indexmin > indexmax)
            {
                int o = indexmin;
                indexmin = indexmax + 1;
                indexmax = o - 1;
            }
            for (; indexmin < indexmax; indexmin++)
                StrangeSum += Arr[indexmin];
            return StrangeSum;
        }
        static double StrangeSum2(int N, double[] Arr)
        {
            int min = 0, max = N, k = 0;
            double sum = 0;
            for (int i = 0; i < N; i++)
                if (Arr[i] == 0)
                {
                    k++;
                    switch (k)
                    {
                        case 1: min = i + 1; break;
                        case 2: max = i; break;
                    }
                }
            if (min == 0 || max == N)
            {
                Console.WriteLine("Від 0 до останнього елемента");
            }
            if (min > max)
            {
                int o = min;
                min = max + 1;
                max = o;
            }
            for (; min < max; min++)
                sum += Arr[min];
            return sum;
        }
        static double maxabsminabs(int N, double[] Arr)
        {
            double m=1;
            double maxabs = Double.MaxValue;
            int indexmax=N;
            int indexmin = 0;
            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(Arr[i]) > Math.Abs(maxabs))
                {
                    maxabs = Arr[i];
                    indexmax = i;
                }
            }
            double minabs = Double.MinValue;
            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(Arr[i]) < Math.Abs(minabs))
                {
                    minabs = Arr[i];
                    indexmin = i + 1;
                }
            }
            if (indexmin > indexmax)
            {
                int o = indexmin;
                indexmin = indexmax + 1;
                indexmin = o - 1;
            }
            for (;indexmin<indexmax;indexmin++)
            {
                m = Arr[indexmin];
            }
            return m;
        }
    }
}
