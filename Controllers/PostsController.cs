using System;
using Microsoft.AspNetCore.Mvc;

namespace InstagramAPIClone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : Controller
    {
        // GET -> ALL POSTS
        [HttpGet]
        public IActionResult Get()
        {
            Console.WriteLine("FETCH ALL POSTS");
            return Ok("ALL POSTS");
        }
        
        // GET -> POST BY ID
        
    }
}