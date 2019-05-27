using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HuginsMadness.Models
{
    public class Character
    {   
        public int CharacterID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        //[CheckValidYear]
        public string Password { get; set; }

        public string SheetUrl { get; set; }

        public virtual Access Access { get; set; }

        public bool RememberMe { get; set; }
    }
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Name")]
        [EmailAddress]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    //public class CheckValidYear : ValidationAttribute
    //{
    //    //Constructor
    //    public CheckValidYear()
    //    {
    //        ErrorMessage = "The earliest opera is Daphne, 1598 by Corsi, Peri and Rinuccini";
    //    }
    //    public override bool IsValid(object value)
    //    {
    //        int year = (int)value;

    //        if (year < 1598)
    //        {
    //            return false;
    //        }
    //        return true;
    //    }
    //}
}