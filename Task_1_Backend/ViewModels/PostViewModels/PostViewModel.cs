﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_1_Backend.ViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string EmailAddress { get; set; }
        public DateTimeOffset CreateTime { get; set; }

        public int CommentsCount { get; set; }
    }
}
