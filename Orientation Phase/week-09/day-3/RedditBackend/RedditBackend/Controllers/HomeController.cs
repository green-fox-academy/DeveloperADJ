using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RedditBackend.Models;
using RedditBackend.Services;

namespace RedditBackend.Controllers
{
    public class HomeController : Controller
    {
        ICRUDRepository<Post> postCrudRepository;
        ICRUDRepository<User> userCrudRepository;
        IPostRepository postRepository;

        public HomeController(ICRUDRepository<Post> postCrudRepository, IPostRepository postRepository, ICRUDRepository<User> userCrudRepository)
        {
            this.postCrudRepository = postCrudRepository;
            this.postRepository = postRepository;
            this.userCrudRepository = userCrudRepository;
        }

        [HttpPost("posts")]
        public IActionResult CreatePost([FromBody]Post post)
        {
            postCrudRepository.Create(post);

            return new JsonResult(post);
        }

        [HttpGet("posts")]
        public IActionResult ReadPosts()
        {
            return new JsonResult(postCrudRepository.Read());
        }

        [HttpPut("posts/{id}/upvote")]
        public IActionResult Upvote(int id)
        {
            return new JsonResult(postRepository.Upvote(id));
        }

        [HttpPut("posts/{id}")]
        public IActionResult Update(int id, [FromBody]Post updatedPost)
        {
            return new JsonResult(postCrudRepository.Update(id, updatedPost));
        }

        [HttpDelete("posts/{id}")]
        public IActionResult Delete(int id)
        {
            return new JsonResult(postCrudRepository.Delete(id));
        }

        [HttpPut("posts/{id}/downvote")]
        public IActionResult Downvote(int id)
        {
            return new JsonResult(postRepository.Downvote(id));
        }
    }
}