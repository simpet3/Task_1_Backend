using System;

namespace Task_1_Backend.ViewModels.PostViewModels
{
    public class NewPostViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string EmailAddress { get; set; }
        public DateTimeOffset CreateTime { get; set; }
    }
}