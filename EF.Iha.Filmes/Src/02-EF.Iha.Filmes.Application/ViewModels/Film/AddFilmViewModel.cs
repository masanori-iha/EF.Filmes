using System.ComponentModel.DataAnnotations;

namespace _02_EF.Iha.Filmes.Application.ViewModels.Film;

public class AddFilmViewModel
{
    [Required(ErrorMessage = "The name is required")]
    [StringLength(50, ErrorMessage = "The name field must contain up to 50 characters")]
    public string Name { get; set; }

    [StringLength(255, ErrorMessage = "The name description must contain up to 255 characters")]
    public string Description { get; set; }
}
