using AutoMapper;
using Task_1_Backend.Models;
using Task_1_Backend.ViewModels.CommentViewModels;

namespace Task_1_Backend.Services.CommentsService.Mapper
{
    public class CommentProfile : Profile
    {
        public CommentProfile() : this("CommentProfile")
        {
        }

        protected CommentProfile(string profileName) : base(profileName)
        {
            CreateMap<Comment, CommentViewModel>();
            CreateMap<NewCommentViewModel, Comment>();
        }
    }
}