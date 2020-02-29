using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTfullWebSvc.Services;

namespace RESTfullWebSvc.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorsController : ControllerBase
    {
        private readonly ILibraryRepository _libraryRepository;

        public AuthorsController(ILibraryRepository courseLibraryRepository)
        {
            _libraryRepository = courseLibraryRepository;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _libraryRepository.GetAuthors();
            return Ok(authors);
        }

        [HttpGet("{authorId}")]
        public IActionResult GetAuthor(Guid authorId)
        {
            var author = _libraryRepository.GetAuthor(authorId);

            if (author == null)
            {
                return NotFound();
            }
            return Ok(author);
        }
    }
}
