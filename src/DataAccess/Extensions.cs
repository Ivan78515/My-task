using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class Extensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<INoteRepository, NoteRepository>();
            serviceCollection.AddDbContext<AppContext>(x =>
            {
                x.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=123;Database=PostgreSQL");
            });
            return serviceCollection;
        }
    }
}
