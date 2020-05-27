using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Common.Models;

namespace TrialAppStruct3.Core.Application.Common.Interfaces
{
    public interface IUserManager
    {
        Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password);

        Task<Result> DeleteUserAsync(string userId);
    }
}