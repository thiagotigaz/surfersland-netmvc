using System.Collections.Generic;
using System.Web.Mvc;
using SurfersLand.Models;
using SurfersLand.ViewModels;

namespace SurfersLand.Controllers
{
    public class BoardsController : Controller
    {
        // GET
        public ActionResult Random()
        {
            var board = new Board() {Name = "Sharpeye"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };
            var viewModel = new RandomBoardVm()
            {
                Board = board,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ViewResult Index()
        {
            var movies = GetBoards();
            return View(movies);
        }

        private IEnumerable<Board> GetBoards()
        {
            return new List<Board>
            {
                new Board {Id = 1, Name = "Sharpeye"},
                new Board {Id = 2, Name = "Lost"}
            };
        }


        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}