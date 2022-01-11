using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;

namespace ServicesData.Interfaces
{
    public interface IStudentService
    {
        void Create(Student student);
        List<Student> GetAll();
        Student Get(Guid id);
        void Update(Student student);
        public void Delete(Guid id);
    }
}
