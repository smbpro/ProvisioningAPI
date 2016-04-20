﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApi.Models
{
    /// <summary>
    /// Provides information to determine which cloud to create the partner in.
    /// </summary>
    public class CloudLocatorInfo
    {
        /// <summary>
        /// Gets or sets the Salesforce Account ID of the distributor.
        /// </summary>
        public string ParentAccountID { get; set; }

        /// <summary>
        /// The 3 letter ISO country code of the address on the account.
        /// </summary>
        public string ThreeLetterCountryCode { get; set; }

        /// <summary>
        /// The 2 letter province (for Canada) or state (for United States) code.
        /// </summary>
        public string TwoLetterRegion { get; set; }

        public string CloudOverride { get; set; }
    }
}