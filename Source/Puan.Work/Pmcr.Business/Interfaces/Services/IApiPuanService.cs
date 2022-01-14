using Pmcr.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pmcr.Business.Interfaces.Services
{
    public interface IApiPuanService
    {
        Task<IEnumerable<PointTime>> GetByType(int id);
    }
}
