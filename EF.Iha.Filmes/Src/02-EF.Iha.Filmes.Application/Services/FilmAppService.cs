using _02_EF.Iha.Filmes.Application.Interfaces;
using _02_EF.Iha.Filmes.Application.ViewModels.Film;
using _03_EF.Iha.Filmes.Domain.Entities;
using _03_EF.Iha.Filmes.Domain.Interfaces;
using AutoMapper;

namespace _02_EF.Iha.Filmes.Application.Services;

public class FilmAppService : IFilmAppService
{
    private readonly IMapper _mapper;
    private readonly IFilmService _service;

    public FilmAppService(IFilmService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ReadFilmViewModel>> GetAll()
    {
        var films = await _service.GetAll();

        return _mapper.Map<IEnumerable<ReadFilmViewModel>>(films);
    }

    public async Task Add(AddFilmViewModel film)
    {
        await _service.Add(_mapper.Map<Film>(film));

        return;
    }
}
