using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Models
{
    public class BlazorSurvey
    {
        [Required(ErrorMessage = "Please enter a name.")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Tell us what you think!")]
        [RegularExpression("awesome", ErrorMessage = "...are you sure?")]
        public String OpinionAboutBlazor { get; set; }
    }
}