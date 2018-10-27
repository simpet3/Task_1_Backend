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

namespace Task_1_Backend.Controllers
{
    [Produces("application/json")]
    [Route("api/Posts")]
    public class PostsController : Controller
    {
        private readonly IBaseService<Post> _service;
        public PostsController(DbContext context)
        {
            _service = new BaseService<Post>(new PostRepository(context));
        }

        // GET: api/Posts
        [HttpGet]
        public IEnumerable<Post> GetPosts()
        {
            return _service.GetAll();
        }

        // GET: api/Posts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var post =  _service.Get(id);

            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        // PUT: api/Posts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePost([FromRoute] int id, [FromBody] Post post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            _service.update(post);

            return NoContent();
        }

        // POST: api/Posts
        [HttpPost]
        public async Task<IActionResult> CreatetPost([FromBody] Post post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _service.Add(post);

           // return  Ok(new { restaurantId });

            return CreatedAtAction("GetPost", new { id = post.Id }, post);
        }

        // DELETE: api/Posts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var post = _service.Get(id);
            if (post == null)
            {
                return NotFound();
            }

            _service.Delete(id);

            return Ok(post);
        }

        private bool PostExists(int id)
        {
            return _service.GetAll().Any(e => e.Id == id);
        }
    }
}