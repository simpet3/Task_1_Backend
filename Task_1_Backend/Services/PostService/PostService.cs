using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1_Backend.Models;
using Task_1_Backend.Repositories;
using Task_1_Backend.ViewModels;
using Task_1_Backend.ViewModels.PostViewModels;

namespace Task_1_Backend.Services.PostService
{
    public class PostService:IPostService
    {
        private readonly IRepository<Post> _postRepository;
        public PostService(IRepository<Post> postRepository)
        {
            this._postRepository = postRepository;
        }

        public IEnumerable<PostViewModel> GetPosts()
        {
            throw new NotImplementedException();
        }

        public PostViewModel GetPost(int id)
        {
            throw new NotImplementedException();
        }

        public NewPostResponseViewModel CreatePost(NewPostViewModel post)
        {
            throw new NotImplementedException();
        }
    }
}
