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
        /// <param name="partner">The unique ID of the partner.</param>
        [Route("Partner/{partnerid}")]
        public void Put(int partnerid, Partner partner)
        {
        }

        //// GET: api/Partner
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Partner/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// DELETE: api/Partner/5
        //public void Delete(int id)
        //{
        //}
    }
}
