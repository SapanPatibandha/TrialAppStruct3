using System;
using System.Collections.Generic;
using System.Text;

namespace TrialAppStruct3.Core.Application.Common.Exception
{
    public class DeleteFailureException : System.Exception
    {
        public DeleteFailureException(string name, object key, string message)
            : base($"Deletion of entity \"{name}\" ({key}) failed. {message}")
        {
        }
    }
}
