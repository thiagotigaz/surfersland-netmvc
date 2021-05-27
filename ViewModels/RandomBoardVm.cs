using System.Collections.Generic;
using SurfersLand.Models;

namespace SurfersLand.ViewModels
{
    public class RandomBoardVm
    {
        public Board Board { get; set; }
        public List<Customer> Customers { get; set; }
    }
}