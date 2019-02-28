using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3020_HW5_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listA = new List<string>() {"aaa", "bbb", "ccc", "ddd" };
            List<string> listB = new List<string>() { "aaa", "ccc", "eee" };
            List<string> listC = new List<string>();

            //Finding strings in listA that are not in listB
            //Via LINQ
            Console.WriteLine("Via Linq:");
            listC = listA.Except(listB).ToList();
            Console.WriteLine(String.Join("\n", listC));

            listC.Clear();

            //Via Loops and If statments
            Console.WriteLine("Via Loops:");
            int exists = 0;
            for (int i = 0; i < listA.Count; i++)
            {
                exists = 0;
                for (int j = 0; j < listB.Count; j++)
                {
                    if (listB[j] == listA[i])
                    {
                        exists = 1;
                    }
                }
                if (exists == 0)
                {
                    listC.Add(listA[i]);
                }
            }
            for (int i = 0; i < listC.Count; i++)
            {
                Console.WriteLine(listC[i]);
            }
        }
    }
}
