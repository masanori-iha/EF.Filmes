using _03_EF.Iha.Filmes.Domain.Entities;

namespace _03_EF.Iha.Filmes.Domain.Interfaces.Repositories;

public interface IFilmRepository
{
    Task<IEnumerable<Film>> GetAll();
    Task Add(Film film);
}
