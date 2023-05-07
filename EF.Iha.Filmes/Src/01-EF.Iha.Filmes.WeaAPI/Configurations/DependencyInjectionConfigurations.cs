using _02_EF.Iha.Filmes.Application.Interfaces;
using _02_EF.Iha.Filmes.Application.Services;
using _03_EF.Iha.Filmes.Domain.Interfaces;
using _03_EF.Iha.Filmes.Domain.Interfaces.Repositories;
using _03_EF.Iha.Filmes.Domain.Services;
using _04_EF.Iha.Filmes.Repository.Repositories;

namespace _01_EF.Iha.Filmes.WeaAPI.Configurations
{
    public static class DependencyInjectionConfigurations
    {
        public static void DependencyInjectionConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IFilmAppService, FilmAppService>();


            builder.Services.AddScoped<IFilmService, FilmService>();


            builder.Services.AddScoped<IFilmRepository, FilmRepository>();
        }
    }
}
