using SampleWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleWebApi.Controllers
{
    /// <summary>
    /// API to create and update partners.
    /// </summary>
    //[Authorize]
    [AllowAnonymous]
    [RoutePrefix("api/partner")]
    public class PartnerController : ApiController
    {
        /// <summary>
        /// Creates a Managed Workplace partner account.
        /// </summary>
        /// <param name="partner"></param> 
        [Route("create")]
        public void CreatePartner(Partner partner)
        {
        }

        /// <summary>
        /// Updates a Managed Workplace partner account.
        /// </summary>
        /// <param name="partner"></param>    
        [Route("update")]
        public void UpdatePartner(Partner partner)
        {
        }
    }
}
