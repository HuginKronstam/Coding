using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HuginsMadness.Models
{
    public class CharCreateDB :DbContext
    {

        public DbSet<Character> Characters { get; set; }
        public DbSet<Access> Accesses { get; set; }
    }
}