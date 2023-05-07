using _04_EF.Iha.Filmes.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace _01_EF.Iha.Filmes.WeaAPI.Configurations
{
    public static class DbConfigurations 
    {
        public static void DbConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<FilmContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("FilmesConnectionString"));
            });

            builder.Services.AddDbContext<FilmContext>();
        }
    }
}
