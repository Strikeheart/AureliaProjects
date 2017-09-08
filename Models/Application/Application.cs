using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AureliaProjects.Models.Application
{
    public class Application
    {
        public string appName { get; set; }
        public Models.ApplicationPool.ApplicationPool appPool { get; set; }
        public string appFolder { get; set; }

        public Models.ResponseMessage.ResponseMessage CreateApplication(Application app)
        {

            Microsoft.Web.Administration.ServerManager iisWeb = new Microsoft.Web.Administration.ServerManager();
            iisWeb.Sites.Add(app.appName, "http", "*:80", app.appFolder);
            iisWeb.ApplicationPoolDefaults.
            Models.ResponseMessage.ResponseMessage rm = new ResponseMessage.ResponseMessage();
            rm.type = "success";
            rm.message = "Anwendung erfolgreich erstellt";
            return rm;
        }

    }
}
