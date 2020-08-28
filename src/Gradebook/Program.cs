using System;
using System.Collections.Generic; 


namespace Gradebook
{
   
   class Program
   {
      static void Main(string[] args)
      {         
         var book = new Book("Greg's Grade Book");

         while (true)
         {
            Console.WriteLine ("Enter a grade or Q to quit");
            string input = Console.ReadLine();
            if (input.ToUpper() == "Q")
               break;

            try 
            {
               var grade = double.Parse (input);
               book.AddGrade (grade);
            }  
            catch (ArgumentException ex)
            {
               System.Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
               System.Console.WriteLine(ex.Message);
            }
            finally
            {
               System.Console.WriteLine("**");
            }
         }

         Statistics statistics = book.GetStatistics();

         System.Console.WriteLine($"Lowest Grade is {statistics.Low}");
         System.Console.WriteLine($"Highest Grade is {statistics.High}");
         System.Console.WriteLine($"Average Grade is {statistics.Average:N1}");
         System.Console.WriteLine($"THe Letter is {statistics.Letter}");
      }
   }
}
