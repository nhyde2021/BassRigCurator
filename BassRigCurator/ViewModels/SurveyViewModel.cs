using BassRigCurator.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BassRigCurator.ViewModels
{
    public class SurveyViewModel
    {
        /*[Required(ErrorMessage = "Budget is required")]
        [Range(90, 25000, ErrorMessage = "Budget must be between $90 and $25,000")]*/
        public int BassBudget { get; set; }
        public int AmpBudget { get; set; }
        public string Volume { get; set; }
        public GenreType Genre { get; set; }
        public List<SelectListItem> GenreTypes { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(GenreType.Rock.ToString(), ((int)GenreType.Rock).ToString()),
            new SelectListItem(GenreType.Jazz.ToString(), ((int)GenreType.Jazz).ToString()),
            new SelectListItem(GenreType.Country.ToString(), ((int)GenreType.Country).ToString()),
            new SelectListItem(GenreType.Metal.ToString(), ((int)GenreType.Metal).ToString()),
            new SelectListItem(GenreType.Funk.ToString(), ((int)GenreType.Funk).ToString())
        };

        public SurveyViewModel()
        {

        }
    }
}
