using Application.MovieOperations.Commands;
using Application.MovieOperations.Queries;
using AutoMapper;
using DbOperations;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public MovieController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var query = new GetMoviesQuery(_context, _mapper);
            return Ok(query.Handle());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var query = new GetMovieDetailQuery(_context, _mapper, id);
            return Ok(query.Handle());
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateMovieM newMovie)
        {
            var command = new CreateMovieCommand(_context, _mapper, newMovie);
            command.Handle();   
            return Ok();
        }
    }
}
