using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Data
{
   public class Teacher
    {
        public Teacher()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
