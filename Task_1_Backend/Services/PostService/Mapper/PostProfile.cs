using AutoMapper;
using Task_1_Backend.Models;
using Task_1_Backend.ViewModels.PostViewModels;

namespace Task_1_Backend.Services.PostService.Mapper
{
    public class PostProfile : Profile
    {
        public PostProfile() : this("PostProfile")
        {
        }

        protected PostProfile(string profileName) : base(profileName)
        {
            CreateMap<Post, PostViewModel>()
                .ForMember(dest => dest.CommentsCount, opts => opts.MapFrom(src => src.Comments.Count));
            CreateMap<NewPostViewModel, Post>();
        }
    }
}