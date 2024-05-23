using Microsoft.AspNetCore.Mvc;
using BookInfoAPI.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BookInfoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private static List<Author> Authors = new List<Author>
        {
            new Author { Id = 1, Name = "F. Scott Fitzgerald", BirthDate = new DateTime(1896, 9, 24) },
            new Author { Id = 2, Name = "Harper Lee", BirthDate = new DateTime(1926, 4, 28) }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Author>> GetAuthors()
        {
            return Authors;
        }

        [HttpGet("{id}")]
        public ActionResult<Author> GetAuthor(int id)
        {
            var author = Authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
            {
                return NotFound();
            }
            return author;
        }

        [HttpPost]
        public ActionResult<Author> CreateAuthor(Author author)
        {
            author.Id = Authors.Max(a => a.Id) + 1;
            Authors.Add(author);
            return CreatedAtAction(nameof(GetAuthor), new { id = author.Id }, author);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAuthor(int id, Author author)
        {
            var existingAuthor = Authors.FirstOrDefault(a => a.Id == id);
            if (existingAuthor == null)
            {
                return NotFound();
            }
            existingAuthor.Name = author.Name;
            existingAuthor.BirthDate = author.BirthDate;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            var author = Authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
            {
                return NotFound();
            }
            Authors.Remove(author);
            return NoContent();
        }
    }
}
