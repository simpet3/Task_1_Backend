using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_1_Backend.Models;
using Task_1_Backend.Repositories;
using Task_1_Backend.Services;
using Task_1_Backend.Services.PostService;
using Task_1_Backend.ViewModels;
using Task_1_Backend.ViewModels.PostViewModels;

namespace Task_1_Backend.Controllers
{
    [Produces("application/json")]
    [Route("api/Posts")]
    public class PostsController : Controller
    {
        private readonly IPostService _postService;
        public PostsController(IPostService postService)
        {
            this._postService = postService;
        }

        // GET: api/Posts
        [HttpGet]
        public IEnumerable<PostViewModel> GetPosts()
        {
            return _postService.GetPosts();
        }

        // GET: api/Posts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var post =  _postService.GetPost(id);

            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        // POST: api/Posts
        [HttpPost]
        public async Task<IActionResult> CreatetPost([FromBody] NewPostViewModel post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newPostRespond = _postService.CreatePost(post);

            return Ok(newPostRespond);
        }


    }
}