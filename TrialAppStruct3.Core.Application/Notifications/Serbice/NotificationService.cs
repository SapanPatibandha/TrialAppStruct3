using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Common.Interfaces;
using TrialAppStruct3.Core.Application.Notifications.Models;

namespace TrialAppStruct3.Core.Application.Notifications.Serbice
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(MessageDto message)
        {
            return Task.CompletedTask;
        }
    }
}