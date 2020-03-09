using System;
using System.Collections.Generic;

namespace studentexcercises
{
  class Student : NSSPerson
  {


    public List<Exercise> Exercises { get; set; } = new List<Exercise>();
    public Student(string firstName, string lastName, string slackHandle, string cohort)
    {
      Cohort = cohort;
      FirstName = firstName;
      LastName = lastName;
      SlackHandle = slackHandle;

    }

  }
}
