using System.Collections.Generic;

namespace studentexcercises
{
  class Cohort
  {
    public string Name { get; set; }

    List<Student> StudentsInCohort { get; set; } = new List<Student>();
    List<Instructor> InstructorsInCohort { get; set; } = new List<Instructor>();
    public Cohort(string name)
    {
      Name = name;
    }
    public void AddStudentToCohort(Student student, Cohort cohort)
    {
      cohort.StudentsInCohort.Add(student);
    }
    public void AddInstructorToCohort(Instructor instructor, Cohort cohort)
    {
      cohort.InstructorsInCohort.Add(instructor);
    }

  }
}
