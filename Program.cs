using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._15
{
    internal class Program
    {

        public static string RunApp(int[]marks,int search)
        {
            int minNum = 0;
            int maxNum = marks.Length - 1;

            int foundElem = -1;

            while (minNum <= maxNum && foundElem == -1)
            {
                int mid = (minNum + maxNum) / 2;
                if (search == marks[mid])
                {
                    foundElem = ++mid;
                    break;
                }
                else if (search < marks[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }

            if (foundElem > -1)
            {
                Console.WriteLine("Found " + search + " at index " + foundElem);
            }
            return "Element Not Found";
        }
        static void Main(string[] args)
        {
            int[] marks = new int[10] { 55, 58, 60, 63, 64, 67, 72, 74, 89, 98 };
            Console.WriteLine("Arrays Elemets are");
            for(int i=0;i<marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
            Console.WriteLine("Enter element to search");
            int search=int.Parse(Console.ReadLine());
            var result=RunApp(marks, search);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
