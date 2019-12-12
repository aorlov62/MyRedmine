using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyRedmine.Models
{
    public class Task
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int AutorId { get; set; }

        public int AssignedToId { get; set; }

        public int Status { get; set; }

        public int Priority { get; set; }

        public int SpendTime { get; set; }

        /*public DateTime DateBegin { get; set; }

        public DateTime DateEnd { get; set; }*/
    }
}