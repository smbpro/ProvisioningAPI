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
    [AllowAnonymous]
    public class UserController : ApiController
    {
        /// <summary>
        /// Creates a user for a partner.
        /// </summary>
        /// <param name="partnerid">The ID of the partner.</param>
        /// <param name="user">Information about the user to create.</param> 
        [Route("partner/{partnerid:int}/user/create")]
        public void CreateUser(int partnerid, User user)
        {
        }

        /// <summary>
        /// Updates a user for a partner.
        /// </summary>
        /// <param name="partnerid">The ID of the partner.</param>
        /// <param name="user">Information about the user to update.</param>       
        [Route("partner/{partnerid:int}/user/update")]
        public void UpdateUser(int partnerid, User user)
        {
        }
    }
}