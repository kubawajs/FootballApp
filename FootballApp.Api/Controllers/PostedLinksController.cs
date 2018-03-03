using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FootballApp.Api.Models;
using FootballApp.Api.Database;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FootballApp.Api.Controllers
{
    [Route("api/postedlinks")]
    public class PostedLinksController : Controller
    {
        private readonly FootballAppContext _context;

        public PostedLinksController(FootballAppContext context)
        {
            _context = context;
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(_context.PostedLinks.ToList());
        }

        [HttpGet("{id}", Name = "GetPostedLink")]
        public IActionResult GetById(Guid id)
        {
            var item = _context.PostedLinks.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new JsonResult(item);
        }
    }
}
