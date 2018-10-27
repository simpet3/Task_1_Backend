using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1_Backend.Models;
using Task_1_Backend.ViewModels;

namespace Task_1_Backend.Services.CommentsService
{
    public interface ICommentService
    {
        IEnumerable<CommentViewModel> GetComments(int postId);
        NewCommentResponseViewModel CreateComment(NewCommentViewModel newComment);
    }
}
