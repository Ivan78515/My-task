using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace BusinesLogica
{
    public static class Extensions
    {
        public static IServiceCollection AddBusinesLogica(this IServiceCollection serviceCollection)
        {
           serviceCollection.AddScoped<INoteService, NoteService>();
            return serviceCollection;
        }
    }
}
