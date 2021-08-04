using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Actor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Movie> StarringMovies { get; set; }
    }
}
