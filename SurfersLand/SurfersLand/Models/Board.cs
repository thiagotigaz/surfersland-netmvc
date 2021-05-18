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
        [Required]
        public BoardType BoardType { get; set; }
        public byte BoardTypeId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte NumberInStock { get; set; }
    }
}