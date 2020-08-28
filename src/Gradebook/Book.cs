using System;
using System.Collections.Generic;

namespace Gradebook
{
   public class Book 
   {
      public Book (string name)
      {
         Name = name;
         _grades = new List<double>();
      }

      public void AddLetterGrade (char c)
      {
         switch (c)
         {
            case 'A' : 
               AddGrade(90);
               break;

            case 'B' :
               AddGrade(80);
               break;

            case 'C' :
               AddGrade(70);
               break;

            case 'D' : 
               AddGrade(60);
               break;
            default:
               AddGrade(0);
               break;
         }
      }

      public Statistics GetStatistics()
      {
         Statistics statistics = new Statistics();
         statistics.Average = 0.0;
         statistics.Low = double.MaxValue;
         statistics.High = double.MinValue;

         for (int index = 0; index < _grades.Count; index++)
         {
            double curGrade = _grades[index];
            statistics.Low = Math.Min (statistics.Low, curGrade);
            statistics.High = Math.Max (statistics.High, curGrade);
            statistics.Average += curGrade;
         }

         statistics.Average /= _grades.Count;

         switch (statistics.Average)
         {
            case var d when d >= 90.0:
               statistics.Letter = 'A';
               break;

            case var d when d >= 80.0:
               statistics.Letter = 'B';
               break;

            case var d when d >= 70.0:
               statistics.Letter = 'C';
               break;

            case var d when d >= 60.0:
               statistics.Letter = 'D';
               break;

            default:
               statistics.Letter = 'F';
               break;
               
         };

         return statistics;
      }
      
      public void ShowStatistics(Statistics statistics)
      {
         System.Console.WriteLine($"Lowest Grade is {statistics.Low}");
         System.Console.WriteLine($"Highest Grade is {statistics.High}");
         System.Console.WriteLine($"Average Grade is {statistics.Average:N1}");
      }

      public void AddGrade (double grade)
      {
         if ((grade >= 0) && (grade <= 100))
         {
            _grades.Add(grade);
         }
         else
         {
            throw new ArgumentException ("Grade is invalid", nameof(grade));
         }
      }

      private List <double> _grades;
      public string Name;
   }
}