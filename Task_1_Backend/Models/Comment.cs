﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_1_Backend.Models
{
    public class Comment: EntityBase
    {
        public string MessageContent { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreateTime { get; set; }
    }
}