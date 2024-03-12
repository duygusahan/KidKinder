using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class StaffBranch
    {
        public int StaffBranchId { get; set; }
        public string  StaffBranchName { get; set; }
        public List<Staff> Staffs { get; set; }

    }
}