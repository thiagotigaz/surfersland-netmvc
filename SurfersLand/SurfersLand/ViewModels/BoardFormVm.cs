using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SurfersLand.Models;

namespace SurfersLand.ViewModels
{
    public class BoardFormVm
    {
        public IEnumerable<BoardType> BoardTypes { get; set; }
        public Board Board { get; set; }

        public string Title
        {
            get
            {
                if (Board != null && Board.Id != 0)
                {
                    return "Edit Board";
                }

                return "New Board";
            }
        }
    }
}