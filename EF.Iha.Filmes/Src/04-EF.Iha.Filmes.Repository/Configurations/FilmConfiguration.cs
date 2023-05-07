using _03_EF.Iha.Filmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _04_EF.Iha.Filmes.Repository.Configurations;

internal class FilmConfiguration : IEntityTypeConfiguration<Film>
{
    public void Configure(EntityTypeBuilder<Film> builder)
    {
        builder.ToTable("film");

        builder.HasKey(x => x.Id);

        builder.Property(f => f.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("varchar(50)");

        builder.Property(f => f.Description)
            .HasColumnName("description")
            .HasColumnType("varchar(255)");

        builder.Property<DateTime>("last_update")
            .IsRequired()
            .HasColumnType("datetime")
            .HasDefaultValueSql("getdate()");
    }
}
