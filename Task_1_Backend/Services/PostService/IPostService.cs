using System.Collections.Generic;
using System.Threading.Tasks;
using Task_1_Backend.ViewModels.PostViewModels;

namespace Task_1_Backend.Services.PostService
{
    public interface IPostService
    {
        Task<IEnumerable<PostViewModel>> GetPosts();
        Task<PostViewModel> GetPost(int id);
        Task<NewPostResponseViewModel> CreatePost(NewPostViewModel post);
    }
}