using Microsoft.AspNetCore.Mvc;
using BookInfoAPI.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BookInfoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private static List<Category> Categories = new List<Category>
        {
            new Category { Id = 1, Name = "Fiction" },
            new Category { Id = 2, Name = "Non-Fiction" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories()
        {
            return Categories;
        }

        [HttpGet("{id}")]
        public ActionResult<Category> GetCategory(int id)
        {
            var category = Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return category;
        }

        [HttpPost]
        public ActionResult<Category> CreateCategory(Category category)
        {
            category.Id = Categories.Max(c => c.Id) + 1;
            Categories.Add(category);
            return CreatedAtAction(nameof(GetCategory), new { id = category.Id }, category);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int id, Category category)
        {
            var existingCategory = Categories.FirstOrDefault(c => c.Id == id);
            if (existingCategory == null)
            {
                return NotFound();
            }
            existingCategory.Name = category.Name;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            Categories.Remove(category);
            return NoContent();
        }
    }
}
