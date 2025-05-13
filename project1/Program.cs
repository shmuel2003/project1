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
        static List<int> lstUser = new List<int>();
        static bool Positive(int number)
        {
            return number >= 0;
        }
        static void InsertByUser()
        {
            int num;
            do
            {
                Console.WriteLine("Enter at least 3 number, to stop press -1");
                num = int.Parse(Console.ReadLine());
                if (Positive(num))
                {
                    lstUser.Add(num);
                }
            }
            while (num != -1 || lstUser.Count < 3);
        }
        static void printLst()
        {
            foreach (int i in lstUser)
            {
                Console.Write(i+" ");
            }
        }
        static List<int> ReverseList()
        {
            List<int>lstReverse = new List<int>(lstUser);
            for (int i=lstUser.Count-1; i>=0; i--)
            {
                lstReverse.Add(lstUser[i]);
            }
            return lstReverse;
        }
        static List<int>Sorted()
        {
            List<int>lstSort = new List<int> (lstUser);
            lstSort.Sort();
            return lstSort;
        }
        static int MaxNum()
        {
            int numBig = 0;
            foreach(int number in lstUser)
            {
                if (number > numBig)
                {
                    numBig = number;
                }
            }
            return numBig;
        }
        static int MinNum()
        {
            int numMin = lstUser[0];
            for (int i = 1; i < lstUser.Count; i++)
            {
                if(lstUser[i] < numMin)
                {
                    numMin = lstUser[i];
                }
            }
            return numMin;
        }
        static int CountList()
        {
            int count = 0;
            foreach(int number in lstUser)
                count++;
            return count;
        }
        static int SumList()
        {
            int sum = 0;
            foreach (int number in lstUser)
                sum += number;
            return sum;
        }

    }
}