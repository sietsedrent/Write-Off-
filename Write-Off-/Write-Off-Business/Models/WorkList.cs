using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_Off_Business.Models
{
    public class WorkList
    {
        public ICollection<WorkItem> _workList;
        public WorkList(ICollection<WorkItem> workList)
        {
            this._workList = workList;
        }
    }
}
