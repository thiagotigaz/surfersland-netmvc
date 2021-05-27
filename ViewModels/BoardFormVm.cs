using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SurfersLand.Models;

namespace SurfersLand.ViewModels
{
    public class BoardFormVm
    {
        public int? Id { get; set; }
        public IEnumerable<BoardType> BoardTypes { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Board Type")]
        public byte? BoardTypeId { get; set; }
        
        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1, 50)]
        [Display(Name = "Number in Stock")]
        public byte? NumberInStock { get; set; }
        public string Title => Id != null ? "Edit Board" : "New Board";

        public BoardFormVm()
        {
            Id = 0;
        }

        public BoardFormVm(Board board)
        {
            Id = board.Id;
            Name = board.Name;
            ReleaseDate = board.ReleaseDate;
            BoardTypeId = board.BoardTypeId;
            NumberInStock = board.NumberInStock;
        }
    }
}