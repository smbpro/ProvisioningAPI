using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApi.Models
{
    public class InstallInfo
    {
        public InstallType InstallType { get; set; }

        public LicenseType InstallStatus { get; set; }
    }
}