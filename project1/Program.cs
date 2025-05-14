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
        //מקבלת מספר ומחזירה ערך בוליאני אם המספר חיובי בהתאם
        static bool Positive(int number)
        {
            return number >= 0;
        }
        //מקבלת ליסט ומחזירה ליסט חדש הפוך
        static List<int> ReverseList(List<int> lstUser)
        {
            List<int>lstReverse = new List<int>();
            for (int i=lstUser.Count-1; i>=0; i--)
            {
                lstReverse.Add(lstUser[i]);
            }
            return lstReverse;
        }
        //מקבלת ליסט ומחזירה ליסט חדש ממויין בסדר עולה
        static List<int>Sorted(List<int> lstUser)
        {
            List<int>lstSort = new List<int> (lstUser);
            lstSort.Sort();
            return lstSort;
        }
        //מקבלת ליסט ומחזירה את המספר הכי גבוה
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
        //מקבלת ליסט ומחזירה את המספר הכי נמוך
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
        //מקבלת ליסט ומחזירה את האורך שלו
        static int CountList(List<int> lstUser)
        {
            int count = 0;
            foreach(int number in lstUser)
                count++;
            return count;
        }
        //מקבלת ליסט ומחזירה את סכום האיברים בו
        static int SumList(List<int> lstUser)
        {
            int sum = 0;
            foreach (int number in lstUser)
                sum += number;
            return sum;
        }
        //מקבלת ליסט ומחזירה את ממוצע המספרים שבו
        static float AvgList(List<int> lstUser)
        {
            return SumList(lstUser) / CountList(lstUser);
        }
        //מקבלת ליסט ומדפיסה אותו בשורה אחת עם רווחים
        static void PrintLst(List<int> lstUser)
        {
            foreach (int i in lstUser)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        //מקבלת מהמשתמש סדרה של מספרים, מאמתת, ומחזירה אותם בליסט
        static List<int> InsertByUser()
        {
            int num;
            List<int> lstUser = new List<int>();
            while (lstUser.Count < 3)
            {
                Console.WriteLine("Enter series at least 3 organs");
                string series = Console.ReadLine();
                List<string> lstseries = new List<string>(series.Split(' '));
                for (int i = 0; i < lstseries.Count; i++)
                {
                    if (int.TryParse(lstseries[i], out num) && (Positive(num)))
                    {
                        lstUser.Add(num);
                        continue;
                    }
                    Console.WriteLine("The series is not valid.\n");
                    break;
                }
            }
            return lstUser;
        }

        //int בתור סטרינג, מאמתת אותו אם יש מספרים חיוביים ומחזירה אותם בליסט של args מקבלת את
        static List<int> InsertByArgs(string [] args)
        { 
            int num;
            List<int> lstArgs = new List<int>();
            foreach (string arg in args)
            {
                if (int.TryParse(arg, out num) && (Positive(num)))
                {
                    lstArgs.Add(num);
                }
            }
            if (lstArgs.Count < 3)
                return InsertByUser();
            return lstArgs;
        }

        //מקבלת סדרה של מספרים, מדפיסה תפריט למשתמש ומפעילה את הפונקציות בהתאם לבחירה שלו
        static void Menu(string[] args)
        {
            List<int> lstUser = new List<int>(InsertByArgs(args));
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
                "j. Exit.\n");
                char choice = Console.ReadLine()[0];
                switch (choice)
                {
                    case 'a':
                        lstUser = InsertByUser();
                        break;
                    case 'b':
                        PrintLst(lstUser);
                        break;
                    case 'c':
                        PrintLst(ReverseList(lstUser));
                        break;
                    case 'd':
                        PrintLst(Sorted(lstUser));
                        break;
                    case 'e':
                        Console.WriteLine(MaxNum(lstUser) + "\n");
                        break;
                    case 'f':
                        Console.WriteLine(MinNum(lstUser) + "\n");
                        break;
                    case 'g':
                        Console.WriteLine(AvgList(lstUser) + "\n");
                        break;
                    case 'h':
                        Console.WriteLine(CountList(lstUser) + "\n");
                        break;
                    case 'i':
                        Console.WriteLine(SumList(lstUser) + "\n");
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

        //הפונקציה הראשית שמפעילה את התוכנית
        static void Main(string[] args)
        {
            Menu(args);
        }
    }
}