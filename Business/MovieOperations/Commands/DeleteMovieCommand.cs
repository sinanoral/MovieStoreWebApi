using DbOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MovieOperations.Commands
{
    public class DeleteMovieCommand
    {
        private readonly IMovieStoreDbContext _context;
        private int _Id { get; set; }

        public DeleteMovieCommand(IMovieStoreDbContext context, int id)
        {
            _context = context;
            _Id = id;
        }

        public void Handle()
        {
            var movie = _context.Movies.SingleOrDefault(movie => movie.Id == _Id);
            if (movie is null)
                throw new InvalidOperationException("Movie not found");

            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }
    }
}
