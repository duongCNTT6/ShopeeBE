using System.Collections;

namespace ShopeeBE.Common.MException
{
    public class MExceptionResponse : Exception
    {
        public string? msgError { get; set; }
        public Dictionary<string, string> objMessageError { get; set; }
        public MExceptionResponse()
        {

        }

        public MExceptionResponse(string? msgError)
        {
            this.msgError = msgError;
        }

        public override string Message => this.msgError;

        public override IDictionary Data => this.objMessageError;

    }
}
