using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MANYdigitalHeroes.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MANYdigitalHeroes.Controllers
{
    [Route("api/hero")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly HeroContext _context;

        public HeroController(HeroContext context)
        {
            _context = context;

            if (_context.Hero.Count() == 0)
            {
                // Create a new HeroItem if collection is empty
                _context.Hero.Add(new Hero { name = "Superman",power ="Flight" });
                _context.Hero.Add(new Hero { name = "Spiderman", power = "Spidersenses" });
                _context.SaveChanges();
            }
        }
        //GET: api/Hero
        //[Route("/GetHeroes")]
        [HttpGet]                                          
        public async Task<ActionResult<IEnumerable<Hero>>> GetHeroes()
        {
            return await _context.Hero.ToListAsync();
        }

        //GET: api/Hero/5
        //[Route("GetHero")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Hero>> GetHero(int id)
        {
            var hero = await _context.Hero.FindAsync(id);
            
            if (hero == null)
            {
                return NotFound();
            }

            return hero;
        }

        //POST: api/Hero
        [HttpPost]
        public async Task<ActionResult<Hero>> PostHero(Hero hero)
        {
            _context.Hero.Add(hero);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetHero), new { id = hero.id }, hero);
        }

        //PUT: api/Hero/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHero(int ID, Hero hero)
        {
            if(ID != hero.id)
            {
                return BadRequest();
            }

            _context.Entry(hero).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //DELETE: api/Hero/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHero(int id)
        {
            var hero = await _context.Hero.FindAsync(id);

            if (hero == null)
            {
                return NotFound();
            }
            _context.Hero.Remove(hero);
            await _context.SaveChangesAsync();

            return Ok(hero);
        }
    }
}
