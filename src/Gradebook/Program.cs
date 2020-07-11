using System;
using System.Collections.Generic;

namespace Gradebook
{
   class Program
   {
      static void Main(string[] args)
      {
         var numbers = new [] { 12.7, 10.3, 0.11, 4.1 };
         
         List<double> grades;

         var result = 0.0;
         foreach (var number in numbers)
         {
            result += number;
         }

         System.Console.WriteLine(result);

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
