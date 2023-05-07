using _02_EF.Iha.Filmes.Application.ViewModels.Film;

namespace _02_EF.Iha.Filmes.Application.Interfaces;

public interface IFilmAppService
{
    Task<IEnumerable<ReadFilmViewModel>> GetAll();
    Task Add(AddFilmViewModel film);
}
