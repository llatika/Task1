using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class Project
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public string Author { get; set; }
        public string Country { get; set; }
        public int CreateDate { get; set; }
        public int ModifiedDate { get; set; }
        public int EndDate { get; set; }

        public string Tags { get; set; }

        public string Login { get; set; }

        public string Description { get; set; }
        public string Conmment { get; set; }

    }
}