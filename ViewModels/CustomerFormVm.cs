using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SurfersLand.Models;

namespace SurfersLand.ViewModels
{
    public class CustomerFormVm
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }  
    }
}