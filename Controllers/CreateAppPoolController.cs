using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace AureliaProjects.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    public class CreateAppPoolController : Controller
    {
        [HttpPost("[action]")]
        public async Task<IActionResult> Create([FromBody] Models.ApplicationPool.ApplicationPool appPool) {
            //Models.ApplicationPool.ApplicationPool appPool = FromJson<Models.ApplicationPool.ApplicationPool>(jsonData);
            string jsonAppPool = Newtonsoft.Json.JsonConvert.SerializeObject(appPool);
            Models.Logger.Logger.CreateLogFile(jsonAppPool);
             
            //Models.ApplicationPool.ApplicationPool appPool = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.ApplicationPool.ApplicationPool>(jsonData);
            return Json(appPool);
        }
        public string Update(string jsonData)
        {
            return "";
        }
        public string Delete(string jsonData)
        {
            return "";
        }
    }
}