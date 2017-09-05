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
    }
}
