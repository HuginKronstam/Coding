using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace OperaWebSite.Models
{
    public class Opera
    {
        public int OperaId { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [CheckValidYear]
        public int Year { get; set; }

        [Required]
        public string Composer { get; set; }
    }
    
    public class CheckValidYear : ValidationAttribute
    {
        //Constructor
        public CheckValidYear()
        {
            ErrorMessage = "The earliest opera is Daphne, 1598 by Corsi, Peri and Rinuccini";
        }
        public override bool IsValid(object value)
        {
            int year = (int)value;

            if(year < 1598)
            {
                return false;
            }
            return true;
        }
    }
}