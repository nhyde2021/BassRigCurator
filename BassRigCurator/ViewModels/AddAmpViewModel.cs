using BassRigCurator.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BassRigCurator.ViewModels
{
    public class AddAmpViewModel
    {
        [Required(ErrorMessage = "Brand is required")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Model is required")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(50, 10000, ErrorMessage ="Price must be at least $50")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public VolumeLevel Volume { get; set; }
        public List<SelectListItem> VolumeLevels { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(VolumeLevel.Silent.ToString(), ((int)VolumeLevel.Silent).ToString()),
            new SelectListItem(VolumeLevel.Quietly.ToString(), ((int)VolumeLevel.Quietly).ToString()),
            new SelectListItem(VolumeLevel.Medium.ToString(), ((int)VolumeLevel.Medium).ToString()),
            new SelectListItem(VolumeLevel.Loud.ToString(), ((int)VolumeLevel.Loud).ToString()),
            new SelectListItem(VolumeLevel.VeryLoud.ToString(), ((int)VolumeLevel.VeryLoud).ToString())
        };

        public AddAmpViewModel()
        {

        }
    }
}
