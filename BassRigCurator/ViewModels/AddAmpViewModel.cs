using BassRigCurator.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BassRigCurator.ViewModels
{
    public class AddAmpViewModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
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
