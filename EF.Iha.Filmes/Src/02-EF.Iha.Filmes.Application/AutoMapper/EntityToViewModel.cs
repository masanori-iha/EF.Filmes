using _02_EF.Iha.Filmes.Application.ViewModels.Film;
using _03_EF.Iha.Filmes.Domain.Entities;
using AutoMapper;

namespace _02_EF.Iha.Filmes.Application.AutoMapper;

public class EntityToViewModel : Profile
{
    public EntityToViewModel()
    {
        CreateMap<Film, AddFilmViewModel>();
        CreateMap<Film, ReadFilmViewModel>();
    }
}
