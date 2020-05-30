using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace TrialAppStruct3BlazorApp.Controllers
{
    //[ApiController]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public abstract class ApplicationControllerBase : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
