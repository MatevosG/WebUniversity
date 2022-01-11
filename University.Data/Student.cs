using System;

namespace University.Data
{
    public class Student
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FullName { get => $"{Firstname} {LastName}"; }

    }
}
