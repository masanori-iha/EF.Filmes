using _03_EF.Iha.Filmes.Domain.Entities;
using _03_EF.Iha.Filmes.Domain.Interfaces;
using _03_EF.Iha.Filmes.Domain.Interfaces.Repositories;

namespace _03_EF.Iha.Filmes.Domain.Services;

public class FilmService : IFilmService
{
    private readonly IFilmRepository _repository;

    public FilmService(IFilmRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Film>> GetAll()
    {
        return await _repository.GetAll();
    }
    
    public async Task Add(Film film)
    {
        await _repository.Add(film);

        return;
    }
}
