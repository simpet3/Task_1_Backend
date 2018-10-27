using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1_Backend.Models;
using Task_1_Backend.ViewModels;
using Task_1_Backend.ViewModels.PostViewModels;

namespace Task_1_Backend.Services.PostService
{
    public interface IPostService
    {
        IEnumerable<PostViewModel> GetPosts();
        PostViewModel GetPost(int id);
        NewPostResponseViewModel CreatePost(NewPostViewModel post);
    }
}
