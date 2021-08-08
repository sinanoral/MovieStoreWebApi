using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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
        EntityEntry<T> Entry<T>(T entity) where T: class;
    }
}
