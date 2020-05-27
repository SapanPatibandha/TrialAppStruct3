using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Common.Interfaces;
using TrialAppStruct3.Core.Application.Notifications.Models;

namespace TrialAppStruct3.Core.Application.Author.Commands.CreateAuthor
{
    public class AuthorCreated : INotification
    {
        public int AuthorID { get; set; }

        public class AuthorCreatedHandler : INotificationHandler<AuthorCreated>
        {
            private readonly INotificationService _notification;

            public AuthorCreatedHandler(INotificationService notification)
            {
                this._notification = notification;
            }

            public async Task Handle(AuthorCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new MessageDto());
            }
        }
    }
}
