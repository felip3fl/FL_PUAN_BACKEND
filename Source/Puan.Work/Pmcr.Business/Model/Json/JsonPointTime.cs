using Pmcr.Business.Model.Json.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pmcr.Business.Model.Json
{
    public class JsonPointTime : JsonBase
    {
        public List<PointTime> data { get; set; }
    }
}
