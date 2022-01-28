using BassRigCurator.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BassRigCurator.ViewModels
{
    public class AddBassViewModel
    {
        [Required(ErrorMessage = "Brand is required")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Model is required")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public GenreType Genre { get; set; }
        public List<SelectListItem> GenreTypes { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(GenreType.Rock.ToString(), ((int)GenreType.Rock).ToString()),
            new SelectListItem(GenreType.Jazz.ToString(), ((int)GenreType.Jazz).ToString()),
            new SelectListItem(GenreType.Country.ToString(), ((int)GenreType.Country).ToString()),
            new SelectListItem(GenreType.Metal.ToString(), ((int)GenreType.Metal).ToString()),
            new SelectListItem(GenreType.Funk.ToString(), ((int)GenreType.Funk).ToString())
        };

        public AddBassViewModel()
        {

        }
    }
}
