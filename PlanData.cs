using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapLichDoAn
{
    [Serializable]
    public class PlanData
    {   
        List<PlanItem> job;
        public List<PlanItem> Job { get => job; set => job = value; }
    }
}
