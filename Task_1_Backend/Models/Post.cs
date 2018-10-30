using System;
using System.Collections.Generic;

namespace Task_1_Backend.Models
{
    public class Post : EntityBase
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string EmailAddress { get; set; }
        public DateTimeOffset CreateTime { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}