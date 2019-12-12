using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyRedmine.Models
{
    public class SpendTime
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int TaskId { get; set; }

        public int TypeWork { get; set; }

        public int Spend { get; set; }

        public string comment { get; set; }
    }
}