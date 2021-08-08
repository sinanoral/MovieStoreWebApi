using AutoMapper;
using DbOperations;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MovieOperations.Commands
{
    public class CreateMovieCommand
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        private CreateMovieM _Model { get; set; }
        public CreateMovieCommand(IMovieStoreDbContext context, IMapper mapper, CreateMovieM model)
        {
            _context = context;
            _mapper = mapper;
            _Model = model;
        }

        public void Handle()
        {
            var movie = _context.Movies.Include(x => x.Genre)
                .Include(x => x.Actors).Include(x => x.Director)
                .SingleOrDefault(x => x.Name == _Model.Name);
            if (movie is not null)
                throw new InvalidOperationException("Movie already exists");

            movie = _mapper.Map<Movie>(_Model);

            _context.Movies.Add(movie);
            _context.SaveChanges();
        }
    }

    public class CreateMovieM
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int DirectorId { get; set; }
        public int GenreId { get; set; }
        public string PublishDate { get; set; }
        public List<int> ActorsIds { get; set; }
    }
}
