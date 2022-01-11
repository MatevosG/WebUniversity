using Microsoft.Extensions.DependencyInjection;
using ServicesData.Implementation;
using ServicesData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesData
{
    public static class UniversityDependancyInjections
    {
        public static IServiceCollection AddUniversityServises(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ITeacherService, TeacherService>();
            return services;
        }
    }
}
