using ServicesData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;

namespace ServicesData.Implementation
{
    internal class StudentService:IStudentService
    {
        private readonly IUniversityDbContext _universityDbContext;
        public StudentService(IUniversityDbContext universityDbContext)
        {
            _universityDbContext = universityDbContext;
        }

        public void Create(Student student)
        {
            _universityDbContext.students.Add(student);
        }

        public List<Student> GetAll()
        {
            return _universityDbContext.students;
        }

        public Student Get(Guid id)
        {
            return _universityDbContext.students.FirstOrDefault(x => x.Id == id);
        }
        public void Update(Student student)
        {
            var oldstudent = _universityDbContext.students.FirstOrDefault(x=>x.Id==student.Id);
            int index = _universityDbContext.students.IndexOf(oldstudent);
            _universityDbContext.students[index] = student;
        }
        public void Delete(Guid id)
        {
            foreach (var item in _universityDbContext.students)
            {
                if (id == item.Id)
                {
                    _universityDbContext.students.Remove(item);
                    break;
                }
            }
        }
    }
}
