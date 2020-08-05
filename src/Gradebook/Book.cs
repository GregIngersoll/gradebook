using System;
using System.Collections.Generic;

namespace Gradebook
{
   public class Book 
   {
      public Book (string name)
      {
         _name = name;
         _grades = new List<double>();
      }

      public Statistics GetStatistics()
      {
         Statistics statistics = new Statistics();
         statistics.Average = 0.0;
         statistics.Low = double.MaxValue;
         statistics.High = double.MinValue;
         foreach (var number in _grades)
         {
            statistics.Low = Math.Min (statistics.Low, number);
            statistics.High = Math.Max (statistics.High, number);
            statistics.Average += number;
         }

         statistics.Average = statistics.Average / _grades.Count;

         return statistics;
      }
      
      public void ShowStatistics()
      {
         Statistics statistics = GetStatistics();
         System.Console.WriteLine($"Lowest number is {statistics.Low}");
         System.Console.WriteLine($"Highest number is {statistics.High}");

         System.Console.WriteLine($"The Average is {statistics.Average:N1}");
      }

      public void AddGrade (double grade)
      {
         if (grade >= 0 && grade <= 100)
            _grades.Add(grade);
      }

      private List <double> _grades;
      private string _name;
   }
}