using SampleWebApi.Models.Services;
using SampleWebApi.Models.Services.Rmm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleWebApi.Controllers
{
    /// <summary>
    /// API to activate and deactivate partner services.
    /// </summary>
    [RoutePrefix("api/v1/Partner/{partnerid}/Service")]
    [AllowAnonymous]
    public class ServiceController : ApiController
    {
        /// <summary>
        /// Activates the RMM service for a partner.
        /// </summary>
        /// <param name="partnerid">The unique ID of the partner.</param>
        /// <param name="rmmServiceActivationInfo"></param>              
        [Route("Rmm/Activate")]
        [AcceptVerbs("POST")]
        public RmmServiceActivationResult ActivateRmm(int partnerid, RmmServiceActivationRequest rmmServiceActivationInfo)
        {
            return null;
        }

        /// <summary>
        /// Activates the Backup service for a partner.
        /// </summary>
        /// <param name="partnerid">The unique ID of the partner.</param>        
        [Route("Backup/Activate")]
        [AcceptVerbs("POST")]
        public void ActivateBackup(int partnerid)
        {
        }

        /// <summary>
        /// Activates the SSO service for a partner.
        /// </summary>
        /// <param name="partnerid">The unique ID of the partner.</param>        
        [Route("Sso/Activate")]
        [AcceptVerbs("POST")]
        public void ActivateSso(int partnerid)
        {
        }

        /// <summary>
        /// Activates the NOC service for a partner.
        /// </summary>
        /// <param name="partnerid">The unique ID of the partner.</param>       
        [Route("Noc/Activate")]
        [AcceptVerbs("POST")]
        public void ActivateNoc(int partnerid)
        {
        }

        /// <summary>
        /// Activates the Helpdesk service for a partner.
        /// </summary>
        /// <param name="partnerid">The unique ID of the partner.</param>        
        [Route("Helpdesk/Activate")]
        [AcceptVerbs("POST")]
        public void ActivateHelpdesk(int partnerid)
        {
        }

        /// <summary>
        /// Deactivates the specified service for a partner.
        /// </summary>
        /// <param name="partnerid">The unique ID of the partner.</param>
        /// <param name="service">The type of service.</param>       
        [Route("Deactivate")]
        [AcceptVerbs("POST")]
        public void Deactivate(int partnerid, Service service)
        {
        }
    }
}
