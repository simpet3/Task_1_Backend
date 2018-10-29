using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task_1_Backend.Models;
using Task_1_Backend.Services.CommentsService;
using Task_1_Backend.ViewModels;

namespace Task_1_Backend.Controllers
{
    [Produces("application/json")]
    [Route("api/Posts/{postId:int}/Comments")]
    public class CommentsByPostController:Controller
    {
        private readonly ICommentService _commentService;
        public CommentsByPostController(ICommentService commentService)
        {
            this._commentService = commentService;
        }

        // GET: api/Posts/1/Comment
        [HttpGet]
        public IEnumerable<CommentViewModel> GetComments([FromRoute] int postId)
        {
            return _commentService.GetComments( postId);
        }

        // POST: api/Posts/1/Comment
        [HttpPost]
        public async Task<IActionResult> CreateComment([FromRoute] int postId, [FromBody] NewCommentViewModel newComment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newCommentResponse = _commentService.CreateComment(newComment);

            return Ok(newCommentResponse);
        }

    }
}
