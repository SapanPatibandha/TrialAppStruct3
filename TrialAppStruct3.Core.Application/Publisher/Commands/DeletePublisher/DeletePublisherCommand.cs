using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrialAppStruct3.Core.Application.Publisher.Commands.DeletePublisher
{
    public class DeletePublisherCommand : IRequest
    {
        public int Id { get; set; }
    }
}
