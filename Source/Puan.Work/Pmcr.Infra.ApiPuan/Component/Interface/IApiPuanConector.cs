using Pmcr.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pmcr.Infra.ApiPuan.Component.Interface
{
    public interface IApiPuanConector
    {
        Task<IEnumerable<PointTime>> GetByType(int id);
    }
}
