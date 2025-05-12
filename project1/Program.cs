using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static List<int> lst1 = new List<int>();
        static void insertByUser()
        {
            int num;
            do
            {
                Console.WriteLine("Enter at least 3 number, to stop press -1");
                num = int.Parse(Console.ReadLine());
                if (Positive(num))
                {
                    lst1.Add(num);
                }
            }
            while (num != -1 || lst1.Count < 3);
        }
        static void printLst()
        {
            foreach (int i in lst1)
            {
                Console.Write(i);
            }
        }
        static void printReverse()
        {
            for(int i=lst1.Count-1; i>=0; i--)
            {
                Console.Write(lst1[i]);
            }
        }
        static void sorted()
        {
            lst1.CopyTo
            lst1.Sort();
        }
        static bool Positive(int number)
        {
            return number >= 0;
        }
    }
}