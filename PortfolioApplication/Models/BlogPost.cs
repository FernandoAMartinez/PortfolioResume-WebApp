using System.Collections.Generic;

namespace PortfolioApplication.Models
{
    public class BlogPost 
    {
        public int Id { get; set; }
        //public Author Author { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public string Resume{ get; set; }
        public string Body { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
