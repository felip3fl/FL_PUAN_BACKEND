using Pmcr.Business.Interfaces.Adapter;
using Pmcr.Business.Model;
using Pmcr.Infra.ApiPuan.Component.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pmcr.Infra.ApiPuan.Adapter
{
    public class ApiPuanAdapter : IApiPuanAdapter
    {
        private readonly IApiPuanConector _apiPuanConector;

        public ApiPuanAdapter(IApiPuanConector apiPuanConector)
        {
            apiPuanConector = _apiPuanConector;
        }

        public async Task<IEnumerable<PointTime>> GetByType(int id)
        {
            return await _apiPuanConector.GetByType(id);
        }
    }
}
