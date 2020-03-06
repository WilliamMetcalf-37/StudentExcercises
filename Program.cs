using System;
using System.Collections.Generic;

namespace studentexcercises
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Exercise> TheExercises = new List<Exercise>();
      List<Student> TheStudents = new List<Student>();

      Student Willy = new Student("Willy", "Metcalf", "3k", "C37");
      Student James = new Student("James", "Nitz", "James", "C3");
      Student Audrey = new Student("Audrey", "Borgra", "3k", "C37");
      Student Kevin = new Student("Kevin", "Penny", "PocketChange", "E7");

      TheStudents.Add(Willy);
      TheStudents.Add(James);
      TheStudents.Add(Audrey);
      TheStudents.Add(Kevin);


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

      C37.AddStudentToCohort(Willy, C37);
      C37.AddStudentToCohort(Audrey, C37);
      C37.AddInstructorToCohort(Steve, C37);
      C3.AddStudentToCohort(James, C3);
      C3.AddInstructorToCohort(Leah, C3);
      E7.AddStudentToCohort(Kevin, E7);
      E7.AddInstructorToCohort(Mo, E7);




      Steve.AddExcerciseToStudent(Willy, TrestleBridge);
      Steve.AddExcerciseToStudent(Willy, Bangazon);
      Steve.AddExcerciseToStudent(Audrey, Bangazon);
      Steve.AddExcerciseToStudent(Audrey, Students);

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
        Console.WriteLine($"-------------------------------");
        foreach (Student student in TheStudents)
        {

          foreach (Exercise exer in student.Exercises)
          {
            if (exer.Name == exercise.Name)
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

    }
  }
}
