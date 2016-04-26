using SampleWebApi.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleWebApi.Controllers
{
    /// <summary>
    /// API to create and update partner users.
    /// </summary>
    [RoutePrefix("api/v1/Partner/{partnerid}")]
    public class UserController : ApiController
    {
        /// <summary>
        /// Creates a user for a partner.
        /// </summary>
        /// <param name="partnerid">The unique ID of the partner.</param>
        /// <param name="user">Information about the user.</param>
        [Route("User")]
        public void Post(int partnerid, User user)
        {
        }

        /// <summary>
        /// Updates a user for a partner.
        /// </summary>
        /// <param name="partnerid">The unique ID of the partner.</param>
        /// <param name="userid">The unique ID of the user.</param>
        /// <param name="user">Information about the user.</param>
        [Route("User/{userid}")]
        public void Put(int partnerid, int userid, User user)
        {
        }       
    }
}
