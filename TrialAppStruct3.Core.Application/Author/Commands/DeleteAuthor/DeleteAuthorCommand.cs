using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrialAppStruct3.Core.Application.Author.Commands.DeleteAuthor
{
    public class DeleteAuthorCommand : IRequest
    {
        public int Id { get; set; }
    }
}
