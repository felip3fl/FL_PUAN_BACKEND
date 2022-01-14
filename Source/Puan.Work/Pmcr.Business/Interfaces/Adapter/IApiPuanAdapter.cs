using Pmcr.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pmcr.Business.Interfaces.Adapter
{
    public interface IApiPuanAdapter
    {
        Task<IEnumerable<PointTime>> GetByType(int id);

    }
}
