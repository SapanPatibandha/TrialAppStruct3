using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using TrialAppStruct3.Core.Application.Common.Interfaces;

namespace TrialAppStruct3.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public string UserId { get; }
    }
}