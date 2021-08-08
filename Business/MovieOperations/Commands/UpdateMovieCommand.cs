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
    public class UpdateMovieCommand
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        private int _Id { get; set; }
        private UpdateMovieM _Model { get; set; }

        public UpdateMovieCommand(IMovieStoreDbContext context, IMapper mapper, int id, UpdateMovieM model)
        {
            _context = context;
            _mapper = mapper;
            _Id = id;
            _Model = model;
        }

        public void Handle()
        {
            var movie = _context.Movies
                .Include(x => x.Genre)
                .Include(x => x.Director)
                .Include(x => x.Actors).SingleOrDefault(movie => movie.Id == _Id);

            if (movie is null)
                throw new InvalidOperationException("Movie not found");

            movie.Name = _Model.Name;
            movie.GenreId = _Model.GenreId;
            movie.DirectorId = _Model.DirectorId;
            movie.Price = _Model.Price;

            _context.SaveChanges();

        }
    }

    public class UpdateMovieM
    {
        public string Name { get; set; }
        public int GenreId { get; set; }
        public int DirectorId { get; set; }
        public decimal Price { get; set; }
    }
}
