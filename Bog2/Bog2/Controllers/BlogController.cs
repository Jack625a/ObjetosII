using Microsoft.AspNetCore.Mvc;
using Bog2.Models;
using System;
using System.Collections.Generic;

namespace Bog2.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            var posts = new List<Posts>
            {
                new Posts
                {
                    Id = 1,
                    Title="Primer Titulo",
                    Description="Descripcion",
                    Date= DateTime.Now,
                    ImageUrl="https://codigofacilito.com/photo_generales_store/29.jpg",
                    VideoUrl="https://www.youtube.com/watch?v=UU8AKk8Slqg",
                }
            };
            return View(posts);
        }
    }
}
