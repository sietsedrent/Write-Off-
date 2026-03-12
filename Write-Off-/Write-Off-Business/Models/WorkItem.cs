using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_Off_Business.Models
{
    internal class WorkItem
    {
        public WorkItem(string _name, int id, string name, double points, bool finished)
        {
            this.name = _name;
            this.id = id;
            this.name = name;
            this.points = points;
            this.finished = finished;
        }
        public int id;
        public string name;
        public double points;
        public bool finished;
    }
}
