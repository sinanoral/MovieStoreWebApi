//using Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DbOperations
//{
//    public class DataGenerator
//    {
//        public static void Initialize(IServiceProvider services)
//        {
//            using var context = new MovieStoreDbContext(
//            services.GetRequiredService<DbContextOptions<MovieStoreDbContext>>());

//            var a1 = new Actor { Id = 1, Name = "Kemal", Surname = "Sunal" };
//            var a2 = new Actor { Id = 2, Name = "Peri", Surname = "Baumeister" };
//            var a3 = new Actor { Id = 3, Name = "Daniel", Surname = "Radcliffe" };

//            var m1 = new Movie { Name = "Blood Red Sky", GenreId = 1, DirectorId = 2, Price = 10, PublishDate = new DateTime(1999, 5, 19), Actors = new List<Actor> { a2 } };
//            var m2 = new Movie { Name = "Harry Potter", GenreId = 2, DirectorId = 3, Price = 15, PublishDate = new DateTime(1999, 5, 19), Actors = new List<Actor> { a3 } };
//            var m3 = new Movie { Name = "Hababam Sinifi", GenreId = 3, DirectorId = 1, Price = 20, PublishDate = new DateTime(1999, 5, 19), Actors = new List<Actor> { a1 } };
            
//            context.Movies.AddRange(
//                new Movie { Id = 1, Name = "Blood Red Sky", GenreId = 1, DirectorId = 2, Price = 10, PublishDate = new DateTime(1999, 5, 19), Actors = new List<Actor> { a2 } },
//                new Movie { Id = 2, Name = "Harry Potter", GenreId = 2, DirectorId = 3, Price = 15, PublishDate = new DateTime(1999, 5, 19), Actors = new List<Actor> { a3 } },
//                new Movie { Id = 3, Name = "Hababam Sinifi", GenreId = 3, DirectorId = 1, Price = 20, PublishDate = new DateTime(1999, 5, 19), Actors = new List<Actor> { a1 }, }
//                );

//            context.Genres.AddRange(
//                new Genre { Id = 1, Name = "Action" },
//                new Genre { Id = 2, Name = "Science Fiction" },
//                new Genre { Id = 3, Name = "Comedy" }
//                );

//            context.Directors.AddRange(
//                new Director { Id = 1, Name = "Ertem", Surname = "Egilmez"},
//                new Director { Id = 2, Name = "Peter", Surname = "Thorwarth"},
//                new Director { Id = 3, Name = "Chris", Surname = "Columbus"}
//               );

//            context.SaveChanges();
//        }
//    }
//}
