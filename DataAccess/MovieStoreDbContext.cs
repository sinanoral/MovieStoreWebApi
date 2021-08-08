using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DbOperations
{
    public class MovieStoreDbContext : DbContext, IMovieStoreDbContext
    {
        //private readonly IConfiguration Configuration;
        //public MovieStoreDbContext(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        public MovieStoreDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer(Configuration.GetConnectionString("Development"));
            options.UseInMemoryDatabase(databaseName: "MovieStore");
        }


        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override EntityEntry<TEntity> Entry<TEntity>(TEntity entity)
        {
            return base.Entry(entity);
        }

    }
}
