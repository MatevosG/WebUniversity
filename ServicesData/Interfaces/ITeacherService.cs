using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;

namespace ServicesData.Interfaces
{
    public interface ITeacherService
    {
        Teacher Get(Guid id);
        List<Teacher> GetAll();
    }
}
