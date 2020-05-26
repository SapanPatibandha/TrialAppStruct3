using System;
using System.Collections.Generic;
using System.Text;

namespace TrialAppStruct3.Core.Application.Common.Exception
{
    public class NotFoundException : System.Exception
    {
        public NotFoundException(string name, object key)
            : base($"Entity \"{name}\" ({key}) was not found.")
        {
        }
    }
}
