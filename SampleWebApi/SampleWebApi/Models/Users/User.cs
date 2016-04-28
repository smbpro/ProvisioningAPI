using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApi.Models.Users
{
    /// <summary>
    /// Represent a Managed Workplace user.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the login name of the user.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the first name of the user.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the user.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email address of the user.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the status of the user.
        /// </summary>
        public UserStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the SSO login ID of the user.
        /// </summary>
        public string FederatedID { get; set; }
    }
}