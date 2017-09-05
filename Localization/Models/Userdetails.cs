using Localization.LocalResource;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Localization.Models
{
    public class Userdetails
    {
        [Required]
        [Display(Name = "Username", ResourceType = typeof(Resource))]
        public string Username { get; set; }


        [Required]
        [Display(Name = "Password", ResourceType = typeof(Resource))]
        public string Password { get; set; }
    }
}