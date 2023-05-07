using _03_EF.Iha.Filmes.Domain.Entities;

namespace _03_EF.Iha.Filmes.Domain.Interfaces;

public interface IFilmService
{
    Task<IEnumerable<Film>> GetAll();
    Task Add(Film film);
}
