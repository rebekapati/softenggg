using Microsoft.AspNetCore.Mvc;
using WebApplicationzh2.BookModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationzh2.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // GET: api/<BookController>
        [HttpGet]
        public IActionResult Get()
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            return Ok(context.Books.ToList());
        }

        // GET api/book/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var book = (from x in context.Books
                       where x.Id == id
                       select x).FirstOrDefault();

            if (book == null)
            {
                return NotFound("Nincs ilyen azonosítójú könyv.");
            }

            return Ok(book);
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            context.Books.Add(book);
            context.SaveChanges();
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            /*FunnyDatabaseContext context = new FunnyDatabaseContext();
            var bookmod = (from x in context.Books
                        where x.Id == id
                        select x).FirstOrDefault();

            if (bookmod == null)
            {
                return NotFound();
            }

            bookmod.Title = value;
            bookmod.Author = value;
            bookmod.Year = int.Parse(value);
            bookmod.Genre = value;
            bookmod.IsAvailable = bool.Parse(value);

            context.SaveChanges();

            return Ok("Sikeres módosítás");*/
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var bookdel = (from x in context.Books
                        where x.Id == id
                        select x).FirstOrDefault();

            if (bookdel == null)
            {
                return NotFound("Nincs ilyen.");
            }

            context.Books.Remove(bookdel);
            context.SaveChanges();

            return Ok("Sikeres törlés!");
        }
    }
}
