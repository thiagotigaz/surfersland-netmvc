using System;
using System.ComponentModel.DataAnnotations;

namespace SurfersLand.Models
{
    public class Board
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public BoardType BoardType { get; set; }
        
        [Display(Name = "Board Type")]
        public byte BoardTypeId { get; set; }
        public DateTime DateAdded { get; set; }
        
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }
    }
}