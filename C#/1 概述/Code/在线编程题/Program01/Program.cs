using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> data = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine();
                data.Add(s);
            }

        }

        static bool isSortByLength(List<string> data)
        {
            for (int i = 0; i < data.Count; i++)
            {

            }
        }
    }
}
