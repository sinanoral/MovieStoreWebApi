using Entities;
using Microsoft.EntityFrameworkCore;

namespace DbOperations
{
    public interface IMovieStoreDbContext
    {
        DbSet<Movie> Movies { get; set; }
        DbSet<Actor> Actors { get; set; }
        DbSet<Director> Directors { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Genre> Genres { get; set; }
        int SaveChanges();
    }
}
