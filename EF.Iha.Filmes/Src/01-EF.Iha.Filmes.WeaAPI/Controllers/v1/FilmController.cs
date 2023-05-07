using _02_EF.Iha.Filmes.Application.Interfaces;
using _02_EF.Iha.Filmes.Application.ViewModels.Film;
using Microsoft.AspNetCore.Mvc;

namespace _01_EF.Iha.Filmes.WeaAPI.Controllers.v1;

[ApiController]
[Route("api/[controller]")]
[ApiVersion("1.0")]
public class FilmController : ControllerBase
{
    private readonly IFilmAppService _appService;

    public FilmController(IFilmAppService appService)
    {
        _appService = appService;
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var films = await _appService.GetAll();

        if(!films.Any())
            return NotFound();

        return Ok(films);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Add(AddFilmViewModel filmView)
    {
        try
        {
            await _appService.Add(filmView);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}
