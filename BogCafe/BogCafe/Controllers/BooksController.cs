using BogCafe.Manager;
using BookLibrary.model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BogCafe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private BookManager mrg = new BookManager();

        // GET: api/<BooksController>
        [HttpGet]
        [EnableCors("AllowOnlyGetPut")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IEnumerable<Book> GetAll()
        {
            return mrg.GetAll();

        }

        // GET api/<BooksController>/5
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            try
            {
                Book book = mrg.Get(id);
                return Ok(book);
            }
            catch (KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }
        }

        [HttpGet]
        [Route("Search")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Get([FromQuery] BookYearFilter filter)
        {
            List<Book> liste = mrg.SearchYear(filter.StartYear, filter.EndYear);

            return (liste.Count == 0) ? NoContent(): Ok(liste);
        }

        // POST api/<BooksController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public Book Post([FromBody] Book b)
        {
            
            return mrg.Create(b);
        }

        // PUT api/<BooksController>/5
        [HttpPut]
        [Route("{id}")]
        public Book Put(int id, [FromBody] Book b)
        {
            return mrg.Update(id, b);
        }

        // DELETE api/<BooksController>/5
        [HttpDelete]
        [Route("{id}")]
        public Book Delete(int id)
        {
            return mrg.Delete(id);
        }

        [HttpGet]
        [Route("Genre/{genre}")]
        public List<Book> GetBooks(string genre)
        {
            return mrg.GetBooks(genre);
        }

        [HttpGet]
        [Route("Author/{author}")]
        public List<Book> GetBooksByAuthor(string author)
        {
            return mrg.GetBookByAuthor(author);
        }
    }
}
