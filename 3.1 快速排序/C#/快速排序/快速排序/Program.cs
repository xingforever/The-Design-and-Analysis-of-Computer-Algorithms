using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 快速排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = GetRandomNums(5, 10);
            Console.WriteLine("排序前：");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0},",a[i]);
            }
            Console.WriteLine("");
            QuickSort(a, 0, a.Length - 1);
            Console.WriteLine("排序后：");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0},", a[i]);
            }
            Console.ReadKey();
            //快排最好的情况是nlog2n
            //最坏的情况是n2
            //平均也是nlog2n

        }

        static int[] GetRandomNums(int count,int range)
        {
            //生成随机数
            Random random = new Random();
            int [] datas = new int[count];
            for (int i = 0; i < count; i++)
            {
                datas[i]=(random.Next(range));
            }
            return datas;

        }
        /// <summary>
        /// 划分算法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        static int Partition(int[] a, int s, int t)
        {
            int i = s, j = t;
            int temp = a[s];//用序列第一个作为基准
            while (i != j)
            {
                //从右向左扫描，找到第一个关键字小于temp的a[j]
                while (j > i && a[j] >= temp)
                {
                    j--;
                }
                a[i] = a[j];//将a[j]前移到 a[i]
                while (i < j && a[i] <= temp)
                {
                    i++;
                }
                a[j] = a[i];
            }
            a[j] = temp;
            return i;
        }

        static void QuickSort(int []a ,int s,int t)
        {
            if (s<t)
            {
                int i = Partition(a, s, t);
                QuickSort(a, s, i - 1);
                QuickSort(a, i+1 ,t);
            }
        }
    }
}
