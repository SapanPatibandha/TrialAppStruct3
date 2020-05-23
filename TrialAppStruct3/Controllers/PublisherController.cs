using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrialAppStruct3.Core.Application.Publisher.Queries.GetPublisherList;

namespace TrialAppStruct3.Controllers
{
    public class PublisherController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IList<PublisherLookupDto>>> GetAll()
        {
            return Ok(await Mediator.Send(new GetPublisherListQuery()));
        }
    }
}