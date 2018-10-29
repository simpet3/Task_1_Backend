using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Task_1_Backend.Models;
using Task_1_Backend.Repositories;
using Task_1_Backend.ViewModels;
using Task_1_Backend.ViewModels.PostViewModels;

namespace Task_1_Backend.Services.PostService
{
    public class PostService:IPostService
    {
        private readonly IRepository<Post> _postRepository;
        private readonly IMapper _mapper;
        public PostService(IRepository<Post> postRepository, IMapper mapper)
        {
            this._postRepository = postRepository;
            this._mapper = mapper;
        }

        public IEnumerable<PostViewModel> GetPosts()
        {
            var posts = _postRepository.GetAll();
            return _mapper.Map<IEnumerable<PostViewModel>>(posts);
        }

        public PostViewModel GetPost(int id)
        {
            var post = _postRepository.Get(id);
            return _mapper.Map<PostViewModel>(post);
        }

        public NewPostResponseViewModel CreatePost(NewPostViewModel post)
        {
            var newPost = _mapper.Map<Post>(post);
            var postId = _postRepository.Add(newPost);

            var response = new NewPostResponseViewModel() {id = postId};
            return response;
        }
    }
}
