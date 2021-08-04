﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Movie
    {
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public string Genre { get; set; }
        public Director Director { get; set; }
        public List<Actor> Actors { get; set; }
        public decimal Price { get; set; }
    }
}
