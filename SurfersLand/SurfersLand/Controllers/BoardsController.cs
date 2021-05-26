using System;
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
            var board = _context.Boards.SingleOrDefault(b => b.Id == id);
            if (board == null)
            {
                return HttpNotFound();
            }

            var vm = new BoardFormVm()
            {
                Board = board,
                BoardTypes = _context.BoardTypes.ToList()
            };
            return View("BoardForm", vm);
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

        public ActionResult New()
        {
            var vm = new BoardFormVm
            {
                BoardTypes = _context.BoardTypes.ToList()
            };
            return View("BoardForm", vm);
        }

        [HttpPost]
        public ActionResult Save(Board board)
        {
            if (board.Id == 0)
            {
                board.DateAdded = DateTime.Now;
                _context.Boards.Add(board);
            }
            else
            {
                var boardInDb = _context.Boards.Single(b => b.Id == board.Id);
                boardInDb.Name = board.Name;
                boardInDb.ReleaseDate = board.ReleaseDate;
                boardInDb.BoardTypeId = board.BoardTypeId;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Boards");
        }
    }
}