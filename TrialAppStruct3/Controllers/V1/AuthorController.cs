using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrialAppStruct3.Core.Application.Author.Commands.CreateAuthor;
using TrialAppStruct3.Core.Application.Author.Commands.DeleteAuthor;
using TrialAppStruct3.Core.Application.Author.Commands.UpdateAuthor;
using TrialAppStruct3.Core.Application.Author.Queries.GetAuthorDetail;
using TrialAppStruct3.Core.Application.Author.Queries.GetAuthorList;

namespace TrialAppStruct3.Controllers.V1
{
    public class AuthorController : ApplicationControllerBaseV1
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IList<AuthorLookupDto>>> GetAll()
        {
            return Ok(await Mediator.Send(new GetAuthorListQuery()));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<AuthorDetailVm>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetAuthorDetailQuery { Id = id }));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Create([FromBody]CreateAuthorCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update([FromBody]UpdateAuthorCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteAuthorCommand { Id = id });

            return NoContent();
        }
    }
}