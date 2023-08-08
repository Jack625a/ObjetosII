using System;
namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set;}
        public string Title { get; set;}
        public string Contenido { get; set;}
        public DateTime Date { get; set;}
        public string ImagenUrl { get; set;}
        public string VideoUrl { get; set;}

    }
}