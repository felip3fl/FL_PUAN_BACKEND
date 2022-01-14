using Newtonsoft.Json;
using Pmcr.Business.Interfaces.Services;
using Pmcr.Business.Model;
using Pmcr.Business.Model.Json;
using Pmcr.Business.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pmcr.Business.Services
{
    public class PuanService : ServiceBase, IApiPuanService
    {
        
        const string UrlPath = "/api/v1/Puan";


        public async Task<IEnumerable<PointTime>> GetByType(int id)
        {
            var teste = JsonConvert.SerializeObject(id);

            var UrlMethod = "GetByType";
            var responseString = await PostAsync(UrlPath + UrlMethod, "");
            var json = JsonConvert.DeserializeObject<JsonPointTime>(responseString);

            return json.data;
        }
    }
}
