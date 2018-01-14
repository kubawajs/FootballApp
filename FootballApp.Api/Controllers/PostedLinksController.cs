using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FootballApp.Api.Models;

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

            if(_context.PostedLinks.Count() == 0)
            {
                _context.PostedLinks.Add(new PostedLink
                {
                    Id = 1,
                    Title = "Valverde nowym trenerem Barcelony!",
                    Url = "http://footroll.pl/valverde-nowym-trenerem-barcelony/",
                    Description = "Ernesto Valverde zastąpił Luisa Enrique na stanowisku trenera FC Barcelony.",
                    Votes = 120
                });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(_context.PostedLinks.ToList());
        }

        [HttpGet("{id}", Name = "GetPostedLink")]
        public IActionResult GetById(long id)
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
