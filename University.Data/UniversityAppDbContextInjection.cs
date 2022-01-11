using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Data
{
   public static class UniversityAppDbContextInjection
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services)
        {
            services.AddSingleton<IUniversityDbContext, UniversityDbContext>();
            return services;
        }
    }
}
