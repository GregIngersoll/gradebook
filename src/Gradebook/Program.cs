using System;
using System.Collections.Generic; 


namespace Gradebook
{
   
   class Program
   {
      static void Main(string[] args)
      {         
         var book = new Book("Greg's Grade Book");
         book.AddGrade (89.1);
         book.AddGrade (90.5);
         book.AddGrade (77.5);
//         var grades = new List <double>() { 12.7, 10.3, 0.11, 4.1 };
//         grades.Add(56.1);

         book.ShowStatistics();
      }
   }
}
