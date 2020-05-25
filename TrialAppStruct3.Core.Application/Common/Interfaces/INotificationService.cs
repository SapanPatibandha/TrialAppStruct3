using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Notifications.Models;

namespace TrialAppStruct3.Core.Application.Common.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(MessageDto message);
    }
}
