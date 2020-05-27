using System;

namespace TrialAppStruct3.Core.Domain.Common
{
    public class AuditEntity
    {
        public string CreateBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }
    }
}