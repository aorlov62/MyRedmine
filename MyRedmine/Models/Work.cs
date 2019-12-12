using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyRedmine.Models
{
    public class Work
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int TaskId { get; set; }

        public int StatusBefore { get; set; }

        public int StatusAfter { get; set; }

        public int AssignedToIdBefore { get; set; }

        public int AssignedToIdAfter { get; set; }

        public int PriorityBefore { get; set; }

        public int PriorityAfter { get; set; }

        public string Comment { get; set; }
    }
}