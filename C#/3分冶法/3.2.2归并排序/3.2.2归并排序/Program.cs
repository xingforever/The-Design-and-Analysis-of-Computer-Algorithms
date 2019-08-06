using System;
namespace _3._2._2归并排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = GetRandomNums(5, 10);
            //int[] a =new int[] { 2, 5, 1, 7, 10, 6, 9, 4, 3, 8 };
            Console.WriteLine("排序前：");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0},", a[i]);
            }
            Console.WriteLine("");
            //自底向上
            //Botton_Up.MergeSort(a, a.Length);  
            //自顶向上
            Top_Down.MergeSort(a, 0, a.Length-1);
            Console.WriteLine("排序后：");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0},", a[i]);
            }
            Console.ReadKey();
        }
        static int[] GetRandomNums(int count, int range)
        {
            //生成随机数
            Random random = new Random();
            int[] datas = new int[count];
            for (int i = 0; i < count; i++)
            {
                datas[i] = (random.Next(range));
            }
            return datas;

        }  

    }
}
