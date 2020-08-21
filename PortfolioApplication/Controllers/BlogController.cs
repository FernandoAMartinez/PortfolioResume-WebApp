using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using PortfolioApplication.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioApplication.Controllers
{
    public class BlogController : Controller
    {

        public IActionResult Index() => View(GetBlogPosts());

        [Route("/Post/{Id}")]
        public IActionResult Post(int Id) => View(GetPostById(Id));
        
        public BlogPost GetPostById(int Id)
        {
            var jsonFile = System.IO.File.ReadAllText(@"C:\\Users\\fernando.b.martinez\\Desktop\\BlogPosts.txt");
            var postFile = JsonConvert.DeserializeObject<List<BlogPost>>(jsonFile);
            var post = postFile.Where(x => x.Id == Id).FirstOrDefault();
            return post;
        }

        public IEnumerable<BlogPost> GetBlogPosts()
        {
            var jsonFile = System.IO.File.ReadAllText(@"C:\\Users\\fernando.b.martinez\\Desktop\\BlogPosts.txt");
            var blogPosts = JsonConvert.DeserializeObject<IEnumerable<BlogPost>>(jsonFile);
            return blogPosts;
        }
    }
}