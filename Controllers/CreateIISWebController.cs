using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AureliaProjects.Models.Application;
using AureliaProjects.Models.ApplicationPool;
using AureliaProjects.Models.IISWeb;
using Microsoft.Web.Administration;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json;

namespace AureliaProjects.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    public class CreateIISWebController : Controller
    {
        [HttpPost("[action]")]
        public IActionResult Create([FromBody] Models.Application.Application app)
        {
            //Models.ApplicationPool.ApplicationPool appPool = FromJson<Models.ApplicationPool.ApplicationPool>(jsonData);
            string jsonAppPool = Newtonsoft.Json.JsonConvert.SerializeObject(app);
            //Models.Logger.Logger.CreateLogFile(jsonAppPool);

            Models.ResponseMessage.ResponseMessage rm = app.CreateApplication(app);
            //Models.ApplicationPool.ApplicationPool appPool = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.ApplicationPool.ApplicationPool>(jsonData);
            return Json(rm);
        }
        internal T FromJson<T>(string s)
        {
             return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(s,
             new Newtonsoft.Json.JsonSerializerSettings()
             {
                 ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore,
                 NullValueHandling = Newtonsoft.Json.NullValueHandling.Include,
                 TypeNameHandling = Newtonsoft.Json.TypeNameHandling.None,
                 Converters = new List<Newtonsoft.Json.JsonConverter>() { new Newtonsoft.Json.Converters.IsoDateTimeConverter() }
             });
        }
    }
}