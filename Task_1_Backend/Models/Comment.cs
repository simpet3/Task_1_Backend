using System;

namespace Task_1_Backend.Models
{
    public class Comment : EntityBase
    {
        public string MessageContent { get; set; }
        public string EmailAddress { get; set; }
        public DateTimeOffset CreateTime { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
    }
}