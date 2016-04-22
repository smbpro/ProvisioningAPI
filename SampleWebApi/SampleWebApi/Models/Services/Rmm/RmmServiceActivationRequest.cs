using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApi.Models.Services.Rmm
{
    /// <summary>
    /// Provides information about how to activate the RMM service for a partner.
    /// </summary>
    public class RmmServiceActivationRequest
    {
        /// <summary>
        /// Provides information to help determine which cloud should be selected.
        /// </summary>
        public CloudLocatorInfo CloudLocatorInfo { get; set; }

        /// <summary>
        /// Provdes licensing information.
        /// </summary>
        public InstallInfo InstallInfo { get; set; }
    }
}