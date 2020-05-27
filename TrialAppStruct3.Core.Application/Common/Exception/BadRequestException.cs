namespace TrialAppStruct3.Core.Application.Common.Exception
{
    public class BadRequestException : System.Exception
    {
        public BadRequestException(string message)
            : base(message)
        {
        }
    }
}