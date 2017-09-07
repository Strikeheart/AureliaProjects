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
        public JsonResult Create(string jsonData) {
            //Models.ApplicationPool.ApplicationPool appPool = FromJson<Models.ApplicationPool.ApplicationPool>(jsonData);
            //string jsonAppPool = Newtonsoft.Json.JsonConvert.SerializeObject(jsonData);
            Models.Logger.Logger.CreateLogFile(jsonData);
            Models.ApplicationPool.ApplicationPool appPool = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.ApplicationPool.ApplicationPool>(jsonData);
            return Json(appPool);
        }
        public string Update(string jsonData)
        {
            Models.ApplicationPool.ApplicationPool appPool = FromJson<Models.ApplicationPool.ApplicationPool>(jsonData);
            return "";
        }
        public string Delete(string jsonData)
        {
            Models.ApplicationPool.ApplicationPool appPool = FromJson<Models.ApplicationPool.ApplicationPool>(jsonData);
            return "";
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