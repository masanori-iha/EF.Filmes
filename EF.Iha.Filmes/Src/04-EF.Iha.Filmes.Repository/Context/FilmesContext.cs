using _03_EF.Iha.Filmes.Domain.Entities;
using _04_EF.Iha.Filmes.Repository.Configurations;
using Microsoft.EntityFrameworkCore;

namespace _04_EF.Iha.Filmes.Repository.Context;

public class FilmContext : DbContext
{
    public DbSet<Film> Films { get; set; }

    public FilmContext(DbContextOptions<FilmContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfiguration(new FilmConfiguration());

    }
}
