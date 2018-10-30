using System;

namespace Task_1_Backend.ViewModels.CommentViewModels
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string MessageContent { get; set; }
        public string EmailAddress { get; set; }
        public DateTimeOffset CreateTime { get; set; }
    }
}