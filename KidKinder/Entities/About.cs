﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class About
    {
        public int AboutId { get; set; }
        public string BigImageUrl { get; set; }
        public string Header { get; set; }
        public string Title { get; set; }
        public string Desciription { get; set; }
        
        public string SmallImage { get; set; }
    }
}