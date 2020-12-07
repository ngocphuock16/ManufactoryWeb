using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufactoryWeb.Models
{
    public class CreateManufactory
    {
        [Display(Name = "Manufactory Name")]
        [Required(ErrorMessage = "Manufactory Name is required.")]
        public string Name { get; set; }
    }
}
