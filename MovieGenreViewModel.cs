using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteGaming.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
        public MyModelSomeData MyPropertyFromMyModel { get; set; } = new MyModelSomeData();
        public Support Sup { get; set; } = new Support();
        public string PathToRoot { get; set; }
        public IFormFile Avatar { get; set; }

        
    }
}
