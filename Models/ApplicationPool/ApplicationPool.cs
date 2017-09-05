using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Web.Administration;

namespace AureliaProjects.Models.ApplicationPool
{
    public class ApplicationPool
    {
        public string applicationName { get; set; }
        public bool Enable32Bit { get; set; }
        public string pipelineMode { get; set; }
        public string runTimeVersion { get; set; }
        public bool enableRapidFailure { get; set; }
        public string mode { get; set; }

        public void a() {
            
        }

    }
}
    