using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace DiagonalDifference
{
    class Program
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int difference = 0, leftnumberaddition = 0, rightnumberaddition = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                    {
                        leftnumberaddition += arr[i][j];
                    }
                    if (i + j + 1 == arr.Count)
                    {
                        rightnumberaddition += arr[i][j];
                    }
                }
            }
            difference = Math.Abs(leftnumberaddition - rightnumberaddition);
            return difference;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            Console.WriteLine("****************");
            int result = diagonalDifference(arr);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
