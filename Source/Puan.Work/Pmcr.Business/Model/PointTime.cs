using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pmcr.Business.Model
{
    public class PointTime
    {
        public long Id { get; set; }
        public long IdKindPointTimes { get; set; }
        public DateTime Mark { get; set; }
        public bool Activated { get; set; }
    }
}
