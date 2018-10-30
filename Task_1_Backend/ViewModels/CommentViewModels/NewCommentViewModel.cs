using System;

namespace Task_1_Backend.ViewModels.CommentViewModels
{
    public class NewCommentViewModel
    {
        public string MessageContent { get; set; }
        public string EmailAddress { get; set; }
        public DateTimeOffset CreateTime { get; set; }
    }
}