namespace studentexcercises
{
  class Instructor
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }

    public string Cohort { get; set; }

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
