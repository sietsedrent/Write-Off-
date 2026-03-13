using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_Off_Business.Models
{
    public class WorkItem
    {
        public WorkList workList;
        public WorkItem(Guid id, string name, double points, bool finished)
        {
            this.id = id;
            this.name = name;
            this.points = points;
            this.finished = finished;            
        }
        public Guid id;
        public string name;
        public double points;
        public bool finished;
    }
}
