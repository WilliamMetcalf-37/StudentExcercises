using System;
using System.Collections.Generic;
using System.Linq;

namespace studentexcercises
{
  class CohortReport
  {
    public string Name { get; set; }
    public int CohortCount { get; set; }
  }
  class Program
  {
    static void Main(string[] args)
    {
      List<Exercise> TheExercises = new List<Exercise>();
      List<Student> TheStudents = new List<Student>();
      List<Instructor> TheInstructors = new List<Instructor>();

      Student Willy = new Student("Willy", "Metcalf", "3k", "C37");
      Student James = new Student("James", "Nitz", "James", "C3");
      Student Audrey = new Student("Audrey", "Borgra", "3k", "C37");
      Student Kevin = new Student("Kevin", "Penny", "PocketChange", "E7");
      Student Namita = new Student("Namita", "Manohar", "Namita", "E7");

      TheStudents.Add(Willy);
      TheStudents.Add(James);
      TheStudents.Add(Audrey);
      TheStudents.Add(Kevin);
      TheStudents.Add(Namita);


      Exercise Students = new Exercise("Students", "C#");
      Exercise Nutshell = new Exercise("Nutshell", "JS");
      Exercise Bangazon = new Exercise("Bangazon", "C#");
      Exercise TrestleBridge = new Exercise("TrestleBridge", "C#");

      TheExercises.Add(Students);
      TheExercises.Add(Nutshell);
      TheExercises.Add(Bangazon);
      TheExercises.Add(TrestleBridge);

      Cohort C37 = new Cohort("C37");
      Cohort C3 = new Cohort("C3");
      Cohort E7 = new Cohort("E7");

      Instructor Steve = new Instructor("Steve", "Brownlee", "Chortlehoort", "C37", "Dad Jokes");
      Instructor Leah = new Instructor("Leah", "Hoefling", "Chortlehoort", "C3", "Lemurs");
      Instructor Mo = new Instructor("Mo", "Silvera", "MoMoney", "E7", "Planning");

      TheInstructors.Add(Steve);
      TheInstructors.Add(Mo);
      TheInstructors.Add(Leah);

      C37.AddStudentToCohort(Willy, C37);
      C37.AddStudentToCohort(Audrey, C37);
      C37.AddInstructorToCohort(Steve, C37);
      C3.AddStudentToCohort(James, C3);
      C3.AddInstructorToCohort(Leah, C3);
      E7.AddStudentToCohort(Kevin, E7);
      E7.AddInstructorToCohort(Mo, E7);




      Steve.AddExcerciseToStudent(Willy, TrestleBridge);
      Steve.AddExcerciseToStudent(Willy, Bangazon);
      Steve.AddExcerciseToStudent(Willy, Nutshell);
      Steve.AddExcerciseToStudent(Audrey, Bangazon);
      Steve.AddExcerciseToStudent(Audrey, Students);
      Steve.AddExcerciseToStudent(Audrey, Nutshell);

      Leah.AddExcerciseToStudent(James, Nutshell);
      Leah.AddExcerciseToStudent(James, Students);

      Mo.AddExcerciseToStudent(Kevin, TrestleBridge);
      Mo.AddExcerciseToStudent(Kevin, Nutshell);



      //   foreach (Student student in TheStudents)
      //   {
      //     Console.WriteLine($"{student.FirstName} {student.LastName}");


      //     foreach (Exercise exer in student.Exercises)
      //     {
      //       Console.WriteLine($"{exer.Language} {exer.Name}");
      //     }
      //     Console.WriteLine($"");

      //   }
      bool hasExercise = false;

      foreach (Exercise exercise in TheExercises)
      {
        Console.WriteLine($"{exercise.Name}");
        Console.WriteLine($"-----------------");
        foreach (Student student in TheStudents)
        {

          foreach (Exercise exer in student.Exercises)
          {
            if (exer == exercise)
            {
              hasExercise = true;
            }
          }
          if (hasExercise == true)
          {
            Console.WriteLine($"{student.FirstName} {student.LastName}");
            hasExercise = false;
          }
        }
        Console.WriteLine($"");

      }



      //part 2

      List<Exercise> JavascriptExercises = TheExercises.Where(exercise => exercise.Language == "JS").ToList();
      Console.WriteLine("Javascript Exercises");
      foreach (var exer in JavascriptExercises)
      {
        Console.WriteLine($"{exer.Name}");
      }

      var C37Students = TheStudents.Where(student => student.Cohort == "C37").ToList();
      var C37Instructors = TheInstructors.Where(inst => inst.Cohort == "C37").ToList();


      Console.WriteLine("C37 students");
      foreach (var student in C37Students)
      {
        Console.WriteLine($"{student.FirstName}{student.LastName}");
      }
      Console.WriteLine("C37 instructors");
      foreach (var inst in C37Instructors)
      {
        Console.WriteLine($"{inst.SlackHandle}");
      }


      Console.WriteLine("Students sorted by last name");
      var sortedStudents = TheStudents.OrderBy(student => student.LastName);
      foreach (var stu in sortedStudents)
      {
        Console.WriteLine($"{stu.FirstName} {stu.LastName}");

      }

      var StudentExerciseCount = TheStudents.Select(student => student.Exercises.Count);
      Console.WriteLine($"Lazy students with no exercises");
      var studentsWithNoExercises = TheStudents.Where(student => student.Exercises.Count == 0);
      foreach (var stu in studentsWithNoExercises)
      {
        Console.WriteLine($"{stu.FirstName} {stu.LastName}");

      }
      Console.WriteLine($"The best students");
      var studentsWithMostExcercises = TheStudents.Where(student => student.Exercises.Count == StudentExerciseCount.Max());
      Console.WriteLine($"With {StudentExerciseCount.Max()} Exercises");
      foreach (var stu in studentsWithMostExcercises)
      {
        Console.WriteLine($"{stu.FirstName} {stu.LastName}");

      }



      var studentsInCohorts = TheStudents.GroupBy(stu => stu.Cohort)
          .Select(stu =>
          {
            return new CohortReport
            {
              Name = stu.Key,
              CohortCount = stu.Count()
            };
          });

      foreach (var report in studentsInCohorts)
      {
        Console.WriteLine($"{report.Name} {report.CohortCount}");
      }

    }
  }
}
