using System;
using System.Collections.Generic;

namespace studentexcercises
{
  class Student
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }

    public string Cohort { get; set; }

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
