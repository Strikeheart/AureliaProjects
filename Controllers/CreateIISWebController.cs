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
using Newtonsoft.Json;

namespace AureliaProjects.Controllers
{
    [Route("api/[controller]")]
    public class CreateIISWebController : Controller
    {
        [HttpGet("[action]")]
        public string CreateAppPool(string jsonData)
        {
            Models.ApplicationPool.ApplicationPool appPool = FromJson<Models.ApplicationPool.ApplicationPool>(jsonData);

            try
            {

            }catch(Exception ex)
            {
                return ex.ToString();
            }
            return "Erfolg";
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