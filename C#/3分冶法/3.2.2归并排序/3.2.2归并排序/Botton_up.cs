using System.Collections.Generic;

namespace _3._2._2归并排序
{
    //二路归并算法 自底向上
    public   class Botton_Up
    {
        /// <summary>
        /// 二路归并算法 自底向上
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
      public   static void MergeSort(int[] a, int n)
        {
            int length;
            //归并length长的两相邻子表
            for (length = 1; length < n; length = 2 * length)
            {
                MergePass(a, length, n);
            }
        }
        //一趟二路归并
        public static void MergePass(int[] a, int length, int n)
        {
            int i;
            //归并length长的两相邻子表
            for (i = 0; i + 2 * length - 1 < n; i = i + 2 * length)
            {
                Merge(a, i, i + length - 1, i + 2 * length - 1);
            }
            //余下的子表 ，后者长度小于length
            if (i + length - 1 < n)
            {
                //归并子表
                Merge(a, i, i + length - 1, n - 1);
            }
        }

        /// <summary>
        /// 将a[low.mid]和a[mid+1..high]两个相邻的有序子序列归并为一个有序子序列a[low..high]
        /// </summary>
        /// <param name="a">数组</param>
        /// <param name="low"></param>
        /// <param name="mid"></param>
        /// <param name="high"></param>
        public static void Merge(int[] a, int low, int mid, int high)
        {
            //最终合并的子序列  个数为high-low +1
            List<int> tempa = new List<int>();
            for (int z = 0; z < high - low + 1; z++)
            {
                tempa.Add(0);
            }
            //k是tempa 的下标，i,j 分别表示两个子表的下标
            int i = low, j = mid + 1, k = 0;
            while (i <= mid && j <= high)
            {
                //当左子表数据小于右子表数据，将左子表数据放入临时list
                if (a[i] < a[j])
                {
                    tempa[k] = a[i];
                    i++; k++;
                }
                //当左子表数据大于右子表数据，将右子表数据放入临时list
                else
                {
                    tempa[k] = a[j];
                    j++; k++;
                }
            }
            //将左子表剩余部分放入临时list
            while (i <= mid)
            {
                tempa[k] = a[i];
                i++; k++;
            }
            //将右边子表剩余部分放入临时list
            while (j <= high)
            {
                tempa[k] = a[j];
                j++; k++;
            }
            //替换数据
            for (k = 0, i = low; i <= high; k++, i++)
            {
                a[i] = tempa[k];
            }
        }
    }
}
