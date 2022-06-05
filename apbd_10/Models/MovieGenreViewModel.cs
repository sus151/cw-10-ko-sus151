﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace apbd_10.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
    }
}