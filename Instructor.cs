namespace studentexcercises
{
  class Instructor : NSSPerson
  {


    public string Specialty { get; set; }


    public void AddExcerciseToStudent(Student student, Exercise exercise)
    {
      student.Exercises.Add(exercise);
    }

    public Instructor(string firstName, string lastName, string slackHandle, string cohort, string specialty)
    {
      Cohort = cohort;
      FirstName = firstName;
      LastName = lastName;
      SlackHandle = slackHandle;
      Specialty = specialty;

    }
  }
}
