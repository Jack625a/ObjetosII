using System;
namespace Bog2.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
    }
}
