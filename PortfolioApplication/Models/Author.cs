using System.Collections.Generic;

namespace PortfolioApplication.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName() => $"{LastName}, {FirstName}";
        public List<Comment> Comments { get; set; }
        public List<BlogPost> BlogPages { get; set; }
    }
}
