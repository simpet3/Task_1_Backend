﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_1_Backend.ViewModels
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string MessageContent { get; set; }
        public string EmailAddress { get; set; }
        public DateTimeOffset CreateTime { get; set; }
    }
}
