using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 选择排序
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static  void  SelectSort(int []a,int n,int i)
        {
            int j, k;
            if (i==n-1)
            {
                //满足递归出口条件
                return;
            }
            else
            {
                //k记录a[i..n-1]中最小元素的下标
                k = i;
                //在a[i..n-1]中找最小元素
                for (j = i+1; j < n; j++)
                {
                    if (a[j]<a[k])
                    {
                        k =j;
                    }
                }
                //若最小元素不是a[i]
                if (k!=i)
                {
                    //a[i]和a[k]交换
                    var temp = a[i];
                    a[i] = a[k];
                    a[k] = temp;
                }
                SelectSort(a, n, i + 1);
            }

        }
    }
}
