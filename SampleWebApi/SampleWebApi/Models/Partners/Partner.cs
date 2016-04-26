using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApi.Models
{
    /// <summary>
    /// Represents a Managed Workplace partner account.
    /// </summary>
    public class Partner
    {
        /// <summary>
        /// Gets or sets the Salesforce Account ID of the partner.
        /// </summary>
        public string AccountID { get; set; }       

        /// <summary>
        /// Gets or sets the name of the partner's company.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the email address of the primary contact on the account.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the first name of the primary contact on the account.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the primary contact on the account.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the status of the partner.
        /// </summary>
        public PartnerStatus Status { get; set; }
    }
}