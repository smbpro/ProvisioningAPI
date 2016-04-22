using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApi.Models.Services.Rmm
{
    /// <summary>
    /// The deployment model of the Managed Workplace installation. 
    /// </summary>
    public enum SoftwareDeployment : int
    {
        /// <summary>
        /// Installed in a cloud environment hosted by AVG or a 3rd party distributor.
        /// </summary>
        Cloud = 1,

        /// <summary>
        /// Installed on premise by the partner in their own data center.
        /// </summary>
        OnPremise = 2
    }
}