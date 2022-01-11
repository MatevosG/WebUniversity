using ServicesData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;

namespace ServicesData.Implementation
{
    internal class TeacherService : ITeacherService
    {
        private readonly IUniversityDbContext _universityDbContext;
        public TeacherService(IUniversityDbContext universityDbContext)
        {
            _universityDbContext = universityDbContext;
        }
        public Teacher Get(Guid id)
        {
            return _universityDbContext.teachers.FirstOrDefault(x => x.Id == id);
        }

        public List<Teacher> GetAll()
        {
            return _universityDbContext.teachers;
        }
    }
}
