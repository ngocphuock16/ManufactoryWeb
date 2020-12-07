using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufactoryWeb.Models
{
    public class DeleteManufactory
    {
        [Display(Name = "Manufactory Id")]
        [Required(ErrorMessage = "ManufactoryId is required.")]
        public int ManufactoryId { get; set; }
    }
}
