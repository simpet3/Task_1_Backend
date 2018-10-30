using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task_1_Backend.Services.PostService;
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
            _postService = postService;
        }

        // GET: api/Posts
        [HttpGet]
        public async Task<IEnumerable<PostViewModel>> GetPosts()
        {
            return await _postService.GetPosts();
        }

        // GET: api/Posts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost([FromRoute] int id)
        {
            var post = await _postService.GetPost(id);
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

            var newPostRespond = await _postService.CreatePost(post);
            return Ok(newPostRespond);
        }
    }
}