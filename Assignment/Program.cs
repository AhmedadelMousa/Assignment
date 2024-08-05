using System.Diagnostics.Tracing;
using static Assignment.ListGenerator;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators
            //var Result1 = ProductsList.Where(P => P.UnitsInStock == 0);
            //foreach (var n in Result1) 
            //{
            //    Console.WriteLine(n);
            //}
            //var Result2 = ProductsList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);
            //foreach (var n in Result2)
            //{
            //    Console.WriteLine(n);
            //}

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result3 = Arr.Where((A, I) => I < 10 && A.Length < I);
            //foreach (var A in Result3) { Console.WriteLine(A); }

            #endregion
            #region  Ordering Operators
            //var Result1 = ProductsList.OrderBy(P => P.ProductName);
            //foreach (var n in Result1) { Console.WriteLine(n); }

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result2 = Arr.OrderBy(A => A, StringComparer.OrdinalIgnoreCase);
            //foreach (var A in Result2)
            //{
            //    Console.WriteLine(A);
            //}

            //var Result3 = ProductsList.OrderByDescending(P => P.UnitsInStock);
            //foreach (var P in Result3)
            //{
            //    Console.WriteLine(P);
            //}

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result4 = Arr.OrderBy(A => A.Length).ThenBy(A => A);
            //foreach (var A in Result4)
            //{
            //    Console.WriteLine(A);
            //}

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result5 = words.OrderBy(word => word.Length).ThenBy(word => word, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in Result5)
            //{
            //    Console.WriteLine(word);
            //}

            //var Result6 = ProductsList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);
            //foreach (var P in Result6)
            //{
            //    Console.WriteLine(P);
            //}

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result7 = Arr.OrderBy(word => word.Length).ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in Result7)
            //{
            //    Console.WriteLine(word);
            //}

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result8 = Arr.Where(A => A.Length > 1 &&A[1]=='i').Reverse();
            //foreach (var A in Result8)
            //{
            //    Console.WriteLine(A);
            //}
                #endregion
        }
    }
}
