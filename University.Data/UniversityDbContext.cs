using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Data
{
    internal class UniversityDbContext : IUniversityDbContext
    {
        public UniversityDbContext()
        {
            students = new List<Student>();
            teachers = new List<Teacher>();
        }
        public List<Student> students { get; set; }
        public List<Teacher> teachers { get ; set ; }
    }
}
