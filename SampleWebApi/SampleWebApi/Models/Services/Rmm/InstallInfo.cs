using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApi.Models.Services.Rmm
{
    /// <summary>
    /// Provides information on the type of Managed Workplace instance to create.
    /// </summary>
    public class InstallInfo
    {
        /// <summary>
        /// Gets or sets the software deployment type.
        /// </summary>
        public SoftwareDeployment Deployment { get; set; }

        /// <summary>
        /// Gets or sets the license key status.
        /// </summary>
        public LicenseType License { get; set; }
    }
}