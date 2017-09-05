using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Web.Administration;

namespace AureliaProjects.Models.IISWeb
{
    public class IISWeb
    {
        public Models.ApplicationPool.ApplicationPool appPool { get; set; }
        public string webSiteName { get; set; }
        public string hostName { get; set; }
        public string physicalPath { get; set; }

        
    }
}
