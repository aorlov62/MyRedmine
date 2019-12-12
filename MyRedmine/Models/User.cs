using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyRedmine.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string HashOfPassword { get; set; }

        public int IsAdmin { get; set; }
    }
}