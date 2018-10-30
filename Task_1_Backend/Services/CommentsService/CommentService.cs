using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Task_1_Backend.Models;
using Task_1_Backend.Repositories;
using Task_1_Backend.ViewModels;

namespace Task_1_Backend.Services.CommentsService
{
    public class CommentService: ICommentService
    {
        private readonly IRepository<Comment> _commentRepository;
        private readonly IRepository<Post> _postRepository;
        private readonly IMapper _mapper;
        public CommentService(IRepository<Comment> commentRepository, IRepository<Post> postRepository, IMapper mapper)
        {
            this._commentRepository = commentRepository;
            this._postRepository = postRepository;
            this._mapper = mapper;
        }

        public IEnumerable<CommentViewModel> GetComments(int postId)
        {
            var posts = _commentRepository.GetAll().Where(X=> X.PostId == postId).ToList();
            return _mapper.Map<IEnumerable<CommentViewModel>>(posts);
        }

        public NewCommentResponseViewModel CreateComment(int postId, NewCommentViewModel comment)
        {
            var newComment = _mapper.Map<Comment>(comment);
            var post = _postRepository.Get(postId);
            newComment.Post = post;
            newComment.PostId = post.Id;

            var addedComment = _commentRepository.Add(newComment);

            var response = new NewCommentResponseViewModel() {Id= addedComment.Id };
            return response;
        }
    }
}
