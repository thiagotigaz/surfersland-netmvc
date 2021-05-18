using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using SurfersLand.Models;
using SurfersLand.ViewModels;

namespace SurfersLand.Controllers
{
    public class BoardsController : Controller
    {
        private ApplicationDbContext _context;

        public BoardsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET
        public ActionResult Details(int id)
        {
            var board = _context.Boards.Include(b => b.BoardType).SingleOrDefault(b => b.Id == id);
            if (board == null)
                return HttpNotFound();

            return View(board);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ViewResult Index()
        {
            var boards = _context.Boards.Include(b => b.BoardType).ToList();
            return View(boards);
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}