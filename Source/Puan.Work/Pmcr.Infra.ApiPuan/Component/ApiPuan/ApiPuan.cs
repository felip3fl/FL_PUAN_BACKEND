using Pmcr.Business.Model;
using Pmcr.Infra.ApiPuan.Component.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pmcr.Infra.ApiPuan.Component.ApiPuan
{
    public class ApiPuan : IApiPuanConector
    {
        public Task<IEnumerable<PointTime>> GetByType(int id)
        {
            throw new NotImplementedException();
        }
    }
}
