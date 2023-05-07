using _03_EF.Iha.Filmes.Domain.Entities;
using _03_EF.Iha.Filmes.Domain.Interfaces.Repositories;
using _04_EF.Iha.Filmes.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace _04_EF.Iha.Filmes.Repository.Repositories;

public class FilmRepository : IFilmRepository
{
    private readonly FilmContext _context;

    public FilmRepository(FilmContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Film>> GetAll()
    {
        var films = await _context.Films.ToListAsync();

        return films;
    }

    public async Task Add(Film film)
    {
        await _context.AddAsync(film);
        await _context.SaveChangesAsync();

        return;
    }
}
