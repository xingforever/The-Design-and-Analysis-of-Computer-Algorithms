using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace N皇后
{
    class Program
    {
        static int[] q = new int[20];//存放皇后在的地方
        static int count;//总共解法
        
        static void Main(string[] args)
        {
            queen(1, 6);
            Console.ReadKey();

        }


        static  void dispasolution(int n)
        {
            ++count;
            Console.WriteLine("第{0}个解", count);
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine("{0},{1}",i,q[i]);
            }
        }
        static bool place(int i, int j)        //测试(i,j)位置能否摆放皇后
        {
            if (i == 1) return true;        //第一个皇后总是可以放置
            int k = 1;
            while (k < i)           //k=1～i-1是已放置了皇后的行
            {
                if ((q[k] == j) || (Math.Abs(q[k] - j) == Math.Abs(i - k)))
                    return false;
                k++;
            }
            return true;
        }
       static void queen(int i, int n)        //放置1～i的皇后
        {
            if (i > n)
                dispasolution(n);       //所有皇后放置结束
            else
            {
                for (int j = 1; j <= n; j++)    //在第i行上试探每一个列j
                    if (place(i, j))        //在第i行上找到一个合适位置(i,j)
                    {
                        q[i] = j;
                        queen(i + 1, n);
                    }
            }
        }
    }
}
