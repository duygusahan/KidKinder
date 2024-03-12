using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string  NameSurname { get; set; }
        public string Department { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public virtual StaffBranch StaffBranch { get; set; }
    }
}