using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Data
{
   public interface IUniversityDbContext
    {
        public List<Student> students { get; set; }
        public List<Teacher> teachers { get; set; }

    }
}
