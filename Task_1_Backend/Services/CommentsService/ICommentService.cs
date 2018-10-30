using System.Collections.Generic;
using System.Threading.Tasks;
using Task_1_Backend.ViewModels.CommentViewModels;

namespace Task_1_Backend.Services.CommentsService
{
    public interface ICommentService
    {
        Task<IEnumerable<CommentViewModel>> GetComments(int postId);
        Task<NewCommentResponseViewModel> CreateComment(int postId, NewCommentViewModel newComment);
    }
}