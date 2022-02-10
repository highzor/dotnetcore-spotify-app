using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using spotifyClone.Models.DbEntities;
using spotifyClone.Models.Interfaces;

namespace spotifyClone.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpotifyController : ControllerBase
    {
        ISpotifyRepository SpotifyRepository;

        public SpotifyController(ISpotifyRepository spotifyRepository)
        {
            SpotifyRepository = spotifyRepository;
        }

        [HttpGet(Name = "GetAllAlbumCategories")]
        public IEnumerable<AlbumCategory> Get()
        {
            return SpotifyRepository.Get();
        }

        [HttpGet("{id}", Name = "GetAlbumCategory")]
        public IActionResult Get(Guid Id)
        {
            AlbumCategory todoItem = SpotifyRepository.Get(Id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return new ObjectResult(todoItem);
        }

        [HttpPost]
        public IActionResult Create([FromBody] AlbumCategory albumCategory)
        {
            if (albumCategory == null)
            {
                return BadRequest();
            }

            SpotifyRepository.Create(albumCategory);
            return CreatedAtRoute("GetAlbumCategory", new { id = albumCategory.Id }, albumCategory);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid Id, [FromBody] AlbumCategory updatedAlbumCategory)
        {
            if (updatedAlbumCategory == null || updatedAlbumCategory.Id != Id)
            {
                return BadRequest();
            }

            var todoItem = SpotifyRepository.Get(Id);
            if (todoItem == null)
            {
                return NotFound();
            }

            SpotifyRepository.Update(updatedAlbumCategory);
            return RedirectToRoute("GetAllAlbumCategories");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid Id)
        {
            var deletedAlbumCategory = SpotifyRepository.Delete(Id);

            if (deletedAlbumCategory == null)
            {
                return BadRequest();
            }

            return new ObjectResult(deletedAlbumCategory);
        }
    }
}
