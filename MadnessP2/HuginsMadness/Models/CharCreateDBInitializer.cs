using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HuginsMadness.Models
{
    public class CharCreateDBInitializer : DropCreateDatabaseAlways<CharCreateDB>
    {
        protected override void Seed(CharCreateDB context)
        {
            var operas = new List<Character>
            {
                new Character
                {
                    Name = "Gamemaster",
                    Password ="test",
                    SheetUrl = "",
                    RememberMe = true
    }
            };

            operas.ForEach(s => context.Characters.Add(s));

            context.SaveChanges();
        }
    }
}