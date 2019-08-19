using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static  void BubbleSort(int []a,int n,int i)
        {
            int j;
            bool exchange;
            if (i == n - 1) return; //满足递归出口条件
            else
            {
                exchange = false;
                for (j = n-1; j >i; j--)
                {
                    //当相邻元素反序时
                    if (a[j]<a[j-1])
                    {
                        var temp = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = temp;
                        exchange = true;
                    }
                    if (exchange==false)
                    {
                        // 未发生交换时直接返
                        return;
                    }
                    else
                    {
                        //发生交换时继续递归调用
                        BubbleSort(a, n, i + 1);
                    }
                }
            }
        }
    }
}
