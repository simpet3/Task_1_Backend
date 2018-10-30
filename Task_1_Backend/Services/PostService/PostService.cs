using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Task_1_Backend.Models;
using Task_1_Backend.Repositories;
using Task_1_Backend.ViewModels.PostViewModels;

namespace Task_1_Backend.Services.PostService
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> _postRepository;
        private readonly IMapper _mapper;

        public PostService(IRepository<Post> postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PostViewModel>> GetPosts()
        {
            var posts = await _postRepository.GetAll();
            return _mapper.Map<IEnumerable<PostViewModel>>(posts);
        }

        public async Task<PostViewModel> GetPost(int id)
        {
            var post = await _postRepository.Get(id);
            return _mapper.Map<PostViewModel>(post);
        }

        public async Task<NewPostResponseViewModel> CreatePost(NewPostViewModel post)
        {
            if (post == null) throw new ArgumentNullException(nameof(post));
            var newPost = _mapper.Map<Post>(post);
            var addedPost = await _postRepository.Add(newPost);
            var response = new NewPostResponseViewModel() {Id = addedPost.Id};
            return response;
        }
    }
}