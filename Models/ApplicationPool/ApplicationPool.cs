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
        public ManagedPipelineMode pipelineMode { get; set; }
        public string runTimeVersion { get; set; }
        public bool enableRapidFailure { get; set; }
        public string mode { get; set; }

        public object CreateAppPool(ApplicationPool appPool) {
            try
            {
                bool checkAppPool = CheckAppPool(appPool);
                if (!checkAppPool)
                {
                    ServerManager serverManager = new ServerManager();
                    Microsoft.Web.Administration.ApplicationPool pool = serverManager.ApplicationPools.Add(appPool.applicationName);
                    pool.Enable32BitAppOnWin64 = appPool.Enable32Bit;
                    pool.ManagedPipelineMode = (appPool.mode == "integrated " ? ManagedPipelineMode.Integrated : ManagedPipelineMode.Classic);
                    pool.ManagedRuntimeVersion = appPool.runTimeVersion;
                    pool.Failure.RapidFailProtection = appPool.enableRapidFailure;
                    return "OK";
                }
                else
                {
                    return "Anwendungspool existiert bereits!";
                }
            }catch(Exception ex)
            {
                Models.Logger.Logger.CreateLogFile(ex.ToString());
                
            }
        }
        private bool CheckAppPool(ApplicationPool appPool)
        {
            ServerManager serverManager = new ServerManager();
            foreach(var item in serverManager.ApplicationPools)
            {
                if(item.Name == appPool.applicationName)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
    