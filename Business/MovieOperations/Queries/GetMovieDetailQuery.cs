using AutoMapper;
using DbOperations;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MovieOperations.Queries
{
    public class GetMovieDetailQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        private int _Id { get; set; }
        public GetMovieDetailQuery(IMovieStoreDbContext context, IMapper mapper, int id)
        {
            _context = context;
            _mapper = mapper;
            _Id = id;
        }

        public MovieDetailVM Handle()
        {
            var movie = _context.Movies.Include(x => x.Genre)
                .Include(x => x.Actors).Include(x => x.Director)
                .SingleOrDefault(x => x.Id == _Id);

            if (movie == null)
                throw new InvalidOperationException("Movie not found");

            return _mapper.Map<MovieDetailVM>(movie);
        }
    }

    public class MovieDetailVM
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
