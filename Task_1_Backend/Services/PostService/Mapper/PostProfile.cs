using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Task_1_Backend.Models;
using Task_1_Backend.ViewModels;
using Task_1_Backend.ViewModels.PostViewModels;

namespace Task_1_Backend.Services.PostService.Mapper
{
    public class PostProfile:Profile
    {
        public PostProfile() : this("PostProfile")
        {

        }

        protected PostProfile(string profileName) : base(profileName)
        {
            CreateMap<Post,PostViewModel>();
            CreateMap<NewPostViewModel, Post>();
            CreateMap<Post, NewPostResponseViewModel>();

        }
    }
}
