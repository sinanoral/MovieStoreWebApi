using AutoMapper;
using DbOperations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Application.MovieOperations.Queries
{
    public class GetMoviesQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetMoviesQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<MovieVM> Handle()
        {
            var movies = _context.Movies.Include(x => x.Genre).Include(x => x.Actors).Include(x => x.Director).ToList();
            return _mapper.Map<List<MovieVM>>(movies);
        }
    }

    public class MovieVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public List<string> Actors { get; set; }
        public decimal Price { get; set; }
    }
}
