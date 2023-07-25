using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMB.Services.Posts
{
    public class Post
    {
        public long Id { get; set; } 
        public DateTime CreatedAt { get; set; }
        public string? Author { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
    }
    public class PostMark
    {
        public long UserId { get; set; }
        public long PostId { get; set; }
        public string? Mark { get; set; }
    }
}