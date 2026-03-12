using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_Off_Business.Models
{
    internal class WorkList
    {
        public ICollection<WorkItem> workList;
        public WorkList(ICollection<WorkItem> workList)
        {
            this.workList = workList;
        }
    }
}
