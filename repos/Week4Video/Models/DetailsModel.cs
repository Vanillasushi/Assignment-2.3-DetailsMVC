using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Week4Video.Shared.Enums;
using Week4Video.Shared.ViewModels;
using Week4Video.Shared.Orchestrators;
using System.ComponentModel.DataAnnotations;

namespace Week4Video.Models
{
    public class DetailsModel
    {
        [Display(Name = "First Name: ")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }
        [Display(Name = "Gender: ")]
        public GenderEnum Gender { get; set; }
        [Display(Name = "Age: ")]
        public int Age { get; set; }
        [Display(Name = "Major: ")]
        public string Major { get; set; }
    }
}