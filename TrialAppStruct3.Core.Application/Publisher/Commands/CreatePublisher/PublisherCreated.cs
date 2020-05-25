using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrialAppStruct3.Core.Application.Common.Interfaces;
using TrialAppStruct3.Core.Application.Notifications.Models;

namespace TrialAppStruct3.Core.Application.Publisher.Commands.CreatePublisher
{
    public class PublisherCreated : INotification
    {
        public int PublisherID { get; set; }

        public class PublisherCreatedHandler : INotificationHandler<PublisherCreated>
        {
            private readonly INotificationService _notification;

            public PublisherCreatedHandler(INotificationService notification)
            {
                this._notification = notification;
            }

            public async Task Handle(PublisherCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new MessageDto());
            }
        }
    }
}
