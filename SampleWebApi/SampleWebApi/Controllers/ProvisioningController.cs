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
    /// Service to create/update partners and partner users.
    /// </summary>
    [Authorize]
    public class ProvisioningController : ApiController
    {
        /// <summary>
        /// Creates a Managed Workplace partner account.
        /// </summary>
        /// <param name="partner"></param>       
        [Route("CreatePartner")]
        public void CreatePartner(Partner partner)
        {
        }

        /// <summary>
        /// Updates a Managed Workplace partner account.
        /// </summary>
        /// <param name="partner"></param>
        [Route("UpdatePartner")]
        public void UpdatePartner(Partner partner)
        {
        }

        /// <summary>
        /// Creates a Managed Workplace user.
        /// </summary>
        /// <param name="user">Information about the user to create.</param>
        [Route("CreateUser")]
        public void CreateUser(User user)
        {
        }

        /// <summary>
        /// Updates a Managed Workplace user.
        /// </summary>
        /// <param name="user">Information about the user to create.</param>
        [Route("UpdateUser")]
        public void UpdateUser(User user)
        {
        }

        /// <summary>
        /// Activates the RMM service for the partner.
        /// </summary>
        /// <param name="partner"></param>
        /// <param name="cloudLocatorInfo"></param>
        /// <param name="installInfo"></param>
        [Route("ActivateRmmService")]
        public void ActivateRmmService(Partner partner, CloudLocatorInfo cloudLocatorInfo, InstallInfo installInfo)
        {
        }        

        /// <summary>
        /// Activates the backup service for the partner.
        /// </summary>
        /// <param name="partner"></param>
        [Route("ActivateBackupService")]
        public void ActivateBackupService(Partner partner)
        {
        }

        /// <summary>
        /// Activates the SSO service for the partner.
        /// </summary>
        /// <param name="partner"></param>
        [Route("ActivateSsoService")]
        public void ActivateSsoService(Partner partner)
        {
        }

        /// <summary>
        /// Activates the NOC service for the partner.
        /// </summary>
        /// <param name="partner"></param>
        [Route("ActivateNocService")]
        public void ActivateNocService(Partner partner)
        {
        }

        /// <summary>
        /// Activates the Helpdesk service for the partner.
        /// </summary>
        /// <param name="partner"></param>
        [Route("ActivateHelpdeskService")]
        public void ActivateHelpdeskService(Partner partner)
        {
        }

        /// <summary>
        /// Deactivates the specified service for the partner.
        /// </summary>
        /// <param name="accountID"></param>
        /// <param name="service"></param>
        [Route("DeactivateService")]
        public void DeactivateService(string accountID, Service service)
        {
        }
    }
}
