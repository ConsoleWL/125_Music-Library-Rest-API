using _125_MusicLibraryWebApi.Data;
using _125_MusicLibraryWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace _125_MusicLibraryWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SongController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult SongsGetAll()
        {
            var songs = _context.Songs.ToList();

            if (songs == null)
                return NotFound(404);

            return StatusCode(200, songs);
        }

        [HttpGet("{id}")]
        public IActionResult SongGet(int id) // is there p
        {
            var song = _context.Songs.Where(s => s.Id == id).SingleOrDefault();

            if (song == null)
                return NotFound();

            return StatusCode(200, song);
        }

        [HttpPost]
        public IActionResult SongAdd([FromBody] Song song)
        {
            if (song is null)
                return BadRequest(400);

            _context.Songs.Add(song);
            _context.SaveChanges();
            return StatusCode(200, song);
        }

        [HttpPut("{id}")]
        public IActionResult SongUpdate(int id, [FromBody] Song songToUpdate)
        {
            if (id != songToUpdate.Id || songToUpdate is null)
                return BadRequest(400);

            var song = _context.Songs.Where(s => s.Id == id).SingleOrDefault();

            if (song is null)
                return NotFound(404);

            song.Title = songToUpdate.Title;
            song.Artist = songToUpdate.Artist;
            song.Album = songToUpdate.Album;
            song.ReleaseDate = songToUpdate.ReleaseDate;
            song.Genre = songToUpdate.Genre;

            _context.SaveChanges();
            return StatusCode(200, song);
        }

        [HttpDelete("{id}")]
        public IActionResult SongDelete(int id)
        {
            var song = _context.Songs.Where(s => s.Id == id).SingleOrDefault();

            if (song is null)
                return NotFound(404);

            _context.Songs.Remove(song);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id}/like")]
        public IActionResult SongLike(int id)
        {
            var song = _context.Songs.Where(s => s.Id == id).SingleOrDefault();

            if (song is null)
                return NotFound();

            song.Like++; // same thing can be done with dislike + add if checkif song has 0 like is it can't go lower
            _context.SaveChanges();
            return StatusCode(200, song);
            
        }
    }
}
