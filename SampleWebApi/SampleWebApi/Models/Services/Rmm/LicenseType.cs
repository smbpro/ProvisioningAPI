using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApi.Models.Services.Rmm
{
    /// <summary>
    /// The license type.
    /// </summary>
    public enum LicenseType : int
    {
        /// <summary>
        /// No billing information on file, software will shut down after X days.
        /// </summary>
        Trial = 1,

        /// <summary>
        /// Customer billing information is on file. 
        /// </summary>
        Paid = 2
    }
}