using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufactoryWeb.Models
{
    public class UpdateManufactory
    {
        public int ManufactoryId { get; set; }
        [Display(Name = "Manufactory Name")]
        [Required(ErrorMessage = "Manufactory Name is required.")]
        public string Name { get; set; }
    }
}
