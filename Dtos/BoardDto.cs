using System;
using System.ComponentModel.DataAnnotations;
using SurfersLand.Models;

namespace SurfersLand.Dtos
{
    public class BoardDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public byte BoardTypeId { get; set; }
        
        public DateTime? DateAdded { get; set; }
        
        public DateTime? ReleaseDate { get; set; }

        public byte NumberInStock { get; set; }
    }
}