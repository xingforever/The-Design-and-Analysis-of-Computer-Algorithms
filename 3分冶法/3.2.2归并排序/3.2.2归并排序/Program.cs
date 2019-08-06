using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._2归并排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = GetRandomNums(5, 10);
            Console.WriteLine("排序前：");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0},", a[i]);
            }
            Console.WriteLine("");
            MergeSort(a, a.Length);
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
        /// <summary>
        /// 二路归并算法 自底向上
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        static void MergeSort(int[] a,  int n)
        {
            int length;
            //归并length长的两相邻子表
            for (
                length = 1; length< n; length=2*length)
            {
                MergePass(a,length,n);

            }
          
        }
        /// <summary>
        /// 二路归并算法 自顶向下
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        static void MergeSort2(int[] a, int low ,int high)
        {
            int mid;
            if (low<high)
            {
                mid = (low + high) / 2;
                MergeSort2(a, low, mid);
                MergeSort2(a, mid + 1, high);
                Merge(a, low, mid, high);
            }
        }

        //一趟二路归并
        static void MergePass(int[] a,int length,int n)
        {
            int i;
            //归并length长的两相邻子表
            for ( i = 0; i+2*length-1 < n; i=i+2*length)
            {
                Merge(a, i, i + length - 1, i + 2 * length - 1);

            }
            //余下的子表 ，后者长度小于length
            if (i+length-1<n)
            {
                //归并子表
                Merge(a, i, i + length - 1,n - 1);
            }
        }


        /// <summary>
        /// 将a[low.mid]和a[mid+1..high]两个相邻的有序子序列归并为一个有序子序列a[low..high]
        /// </summary>
        /// <param name="a">数组</param>
        /// <param name="low"></param>
        /// <param name="mid"></param>
        /// <param name="high"></param>
        static void  Merge(int []a ,int low,int mid ,int high)
        {
            //最终合并的子序列  个数为high-low +1
            List<int> tempa = new List<int>();
            for (int z = 0; z < high-low+1; z++)
            {
                tempa.Add(0);
            }
            //k是tempa 的下标，i,j 分别表示两个子表的下标
            int i = low, j = mid + 1, k = 0;
            while (i<=mid&&j<=high)
            {
                //当左子表数据小于右子表数据，将左子表数据放入临时list
                if (a[i]<a[j])
                {
                    tempa[k] = a[i];
                    i++;k++;
                }
                //当左子表数据大于右子表数据，将右子表数据放入临时list
                else
                {
                    tempa[k] = a[j];
                    j++;k++;
                }
            }
            //将左子表剩余部分放入临时list
            while (i<=mid)
            {
                tempa[k]=a[i];
                i++;k++;
            }
            //将右边子表剩余部分放入临时list
            while (j <= high)
            {
                tempa[k] = a[j];
                j++; k++;
            }
            //替换数据
            for ( k = 0,i=low; i <=high; k++,i++)
            {
                a[i] = tempa[k];
            }
        }

        static void Merge2(int[] a, int low, int mid, int high)
        {
            //最终合并的子序列  个数为high-low +1
            List<int> tempa = new List<int>();
            //k是tempa 的下标，i,j 分别表示两个子表的下标
            int i = low, j = mid + 1;
            while (i <= mid && j <= high)
            {
                //当左子表数据小于右子表数据，将左子表数据放入临时list
                if (a[i] < a[j])
                {
                    tempa.Add(a[i]);
                    i++;
                }
                //当左子表数据大于右子表数据，将右子表数据放入临时list
                else
                {
                    tempa.Add(a[j]);
                    j++; 
                }
            }
            //将左子表剩余部分放入临时list
            while (i <= mid)
            {
                tempa.Add(a[i]);
                i++; 
            }
            //将右边子表剩余部分放入临时list
            while (j <= high)
            {
                tempa.Add(a[j]);
                i++; 
            }
            //替换数据
            for (int z = low , k = 0;  z <= high; k++, i++)
            {
                a[z] = tempa[k];
            }
        }
    }
}
