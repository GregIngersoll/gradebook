using System;
using System.Collections.Generic;

namespace Gradebook
{
   class Program
   {
      static void Main(string[] args)
      {         
         var grades = new List <double>() { 12.7, 10.3, 0.11, 4.1 };
         grades.Add(56.1);

         var result = 0.0;
         foreach (var number in grades)
         {
            result += number;
         }

         var mean = result / grades.Count;

         System.Console.WriteLine($"The result is {result:N1} and the average (mean) is {mean:N1}");

         if (args.Length > 0)
         {
            Console.WriteLine ($"Hello, {args[0]}!");
         }
         else
         {
            Console.WriteLine ("Hello!");
         }           
      }
   }
}
