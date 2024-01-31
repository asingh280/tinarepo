using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinaKingSystem.BLL;
using TinaKingSystem.DAL;

namespace TinaKingSystem
{
    public static class TinaKingExtension
    {
        public static void AddBackendDependencies(this IServiceCollection services , Action<DbContextOptionsBuilder> options)
        {

            services.AddDbContext<WFS_2590Context>(options);

         /*   services.AddTransient<AuthenticationService>((ServiceProvider) =>
            {
                var context = ServiceProvider.GetService<WFS_2590Context>();
                return new AuthenticationService(context);
            });
            services.AddScoped<AuthenticationService>();*/

        }


    }
}
