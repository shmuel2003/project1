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
        static bool Positive(int number)
        {
            return number >= 0;
        }
        static List<int> ReverseList(List<int> lstUser)
        {
            List<int>lstReverse = new List<int>(lstUser);
            for (int i=lstUser.Count-1; i>=0; i--)
            {
                lstReverse.Add(lstUser[i]);
            }
            return lstReverse;
        }
        static List<int>Sorted(List<int> lstUser)
        {
            List<int>lstSort = new List<int> (lstUser);
            lstSort.Sort();
            return lstSort;
        }
        static int MaxNum(List<int> lstUser)
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
        static int MinNum(List<int> lstUser)
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
        static int CountList(List<int> lstUser)
        {
            int count = 0;
            foreach(int number in lstUser)
                count++;
            return count;
        }
        static int SumList(List<int> lstUser)
        {
            int sum = 0;
            foreach (int number in lstUser)
                sum += number;
            return sum;
        }
        static float AvgList(List<int> lstUser)
        {
            return SumList(lstUser) / CountList(lstUser);
        }
        static void printLst(List<int> lstUser)
        {
            foreach (int i in lstUser)
            {
                Console.Write(i + " ");
            }
        }
        static void ChoiceUser(List<int> lstUser)
        {
            bool isProper = true;
            while (isProper)
            {
                Console.WriteLine(
                "a. Input a Series. (Replace the current series)\n" +
                "b. Display the series in the order it was entered.\n" +
                "c. Display the series in the reversed order it was entered.\n" +
                "d. Display the series in sorted order (from low to high).\n" +
                "e. Display the Max value of the series.\n" +
                "f. Display the Min value of the series.\n" +
                "g. Display the Average of the series.\n" +
                "h. Display the Number of elements in the series.\n" +
                "i. Display the Sum of the series.\n" +
                "j. Exit.");
                char choice = Console.ReadLine()[0];
                switch (choice)
                {
                    case 'a':
                        InsertByUser();
                        isProper = false;
                        break;
                    case 'b':
                        printLst(lstUser);
                        break;
                    case 'c':
                        printLst(ReverseList(lstUser));
                        break;
                    case 'd':
                        printLst(Sorted(lstUser));
                        break;
                    case 'e':
                        Console.WriteLine(MaxNum(lstUser));
                        break;
                    case 'f':
                        Console.WriteLine(MinNum(lstUser));
                        break;
                    case 'g':
                        Console.WriteLine(AvgList(lstUser));
                        break;
                    case 'h':
                        Console.WriteLine(CountList(lstUser));
                        break;
                    case 'i':
                        Console.WriteLine(SumList(lstUser));
                        break;
                    case 'j':
                        isProper = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect choice");
                        break;
                }
            }
        }
        static void InsertByUser()
        {
            List<int> lstUser = new List<int>();
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
            ChoiceUser(lstUser);
        }
        static void Main(string[] args)
        {
            InsertByUser();
        }
    }
}