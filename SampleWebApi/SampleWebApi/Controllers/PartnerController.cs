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
    [RoutePrefix("api/v1")]
    public class PartnerController : ApiController
    {       
        /// <summary>
        /// Creates a Managed Workplace partner account.
        /// </summary>
        /// <param name="partner"></param>
        [Route("Partner")]
        public void Post(Partner partner)
        {
        }

        /// <summary>
        /// Updates a Managed Workplace partner account.
        /// </summary>
        /// <param name="AccountId">The Salesforce AccountId of the partner.</param>
        /// <param name="partner"></param>
        [Route("Partner/{AccountId}")]
        public void Put(string AccountId, Partner partner)
        {
        }

        /// <summary>
        /// Gets a Managed Workplace partner account.
        /// </summary>
        /// <param name="AccountId">The Salesforce AccountId of the partner.</param>
        /// <returns></returns>
        [Route("Partner/{AccountId}")]
        public Partner Get(string AccountId)
        {
            return null;
        }

        //// GET: api/Partner
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// DELETE: api/Partner/5
        //public void Delete(int id)
        //{
        //}
    }
}
