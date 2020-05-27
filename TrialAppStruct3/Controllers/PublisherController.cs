using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Publisher.Commands.CreatePublisher;
using TrialAppStruct3.Core.Application.Publisher.Commands.DeletePublisher;
using TrialAppStruct3.Core.Application.Publisher.Commands.UpdatePublisher;
using TrialAppStruct3.Core.Application.Publisher.Queries.GetPublisherDetail;
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

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<PublisherDetailVm>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetPublisherDetailQuery { Id = id }));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Create([FromBody]CreatePublisherCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update([FromBody]UpdatePublisherCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeletePublisherCommand { Id = id });

            return NoContent();
        }
    }
}