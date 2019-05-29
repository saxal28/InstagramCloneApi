using Microsoft.AspNetCore.Mvc;

namespace InstagramAPIClone.Controllers
{
    public class PostsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}