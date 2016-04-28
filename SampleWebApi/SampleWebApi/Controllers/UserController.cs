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
    [RoutePrefix("api/v1/Partner/{AccountId}")]
    public class UserController : ApiController
    {
        /// <summary>
        /// Creates a user for a partner.
        /// </summary>
        /// <param name="AccountId"></param>
        /// <param name="user"></param>
        [Route("User")]
        public void Post(string AccountId, User user)
        {
        }


        /// <summary>
        /// Updates a user for a partner.
        /// </summary>
        /// <param name="AccountId"></param>
        /// <param name="UserId"></param>
        /// <param name="user"></param>
        [Route("User/{UserId}")]
        public void Put(string AccountId, string UserId, User user)
        {
        }

        /// <summary>
        /// Gets a user for a partner.
        /// </summary>
        /// <param name="AccountId"></param>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [Route("User/{UserId}")]
        public User Get(string AccountId, string UserId)
        {
            return null;
        }
    }
}
