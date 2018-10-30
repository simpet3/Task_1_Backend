using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Task_1_Backend.Models;
using Task_1_Backend.Repositories;
using Task_1_Backend.ViewModels.CommentViewModels;

namespace Task_1_Backend.Services.CommentsService
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IRepository<Post> _postRepository;
        private readonly IMapper _mapper;

        public CommentService(ICommentRepository commentRepository, IRepository<Post> postRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CommentViewModel>> GetComments(int postId)
        {
            var posts = await _commentRepository.GetCommentsByPostId(postId);
            return _mapper.Map<IEnumerable<CommentViewModel>>(posts);
        }

        public async Task<NewCommentResponseViewModel> CreateComment(int postId, NewCommentViewModel comment)
        {
            var newComment = _mapper.Map<Comment>(comment);
            var post = await _postRepository.Get(postId);
            newComment.Post = post;
            newComment.PostId = post.Id;
            var addedComment = await _commentRepository.Add(newComment);
            var response = new NewCommentResponseViewModel() {Id = addedComment.Id};
            return response;
        }
    }
}