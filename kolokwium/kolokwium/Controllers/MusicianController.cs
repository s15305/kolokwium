using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kolokwium.DTOs.Request;
using kolokwium.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace kolokwium.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicianController : ControllerBase
    {
        private readonly MusiciansDbContext _context;
        public MusicianController(MusiciansDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetTworczosc(int id)
        {
            ICollection<Musician_Track> tworczosc;
            if (id <= 0)
            {
                return BadRequest("Numer id muzyka musi być większ od 0");
            }
            else
            {
                tworczosc = _context.Musician_Track
                            .Where(i => i.IdMusician.IdMusician = id)
                            .ToList();
            }
            return Ok();
        }

        [HttpPost]

        public IActionResult AddMusician(AddMusician request)
        {
            if (request.author.Count == 0) return BadRequest("Muzyk musi miec min. jeden utwór");
            return Ok();

            var newMusician = new Musician
            {
                FirstName = request.FirstName,
                LastName = request.LastName

            };

            var newMusicianTrack = request.author.Select(m => new Musician
            {
                IdMusician = m.IdMusician,
                FirstName = m.FirstName,
                LastName = m.LastName,
                Nickname = m.Nickname,
                Musician_Track = _context.Musician.Where(mw => mw.FirstName == m.FirstName).First()

            });

            _context.Musician.Add(newMusician);

            _context.SaveChanges();
            return Ok();

        }
    }
}