using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1_Backend.Models;
using Task_1_Backend.Repositories;
using Task_1_Backend.ViewModels;

namespace Task_1_Backend.Services.CommentsService
{
    public class CommentService: ICommentService
    {
        private readonly IRepository<Comment> _commentRepository;
        public CommentService(IRepository<Comment> commentRepository)
        {
            this._commentRepository = commentRepository;
        }

        public IEnumerable<CommentViewModel> GetComments(int postId)
        {
            throw new NotImplementedException();
        }

        public NewCommentResponseViewModel CreateComment(NewCommentViewModel newComment)
        {
            throw new NotImplementedException();
        }
    }
}
