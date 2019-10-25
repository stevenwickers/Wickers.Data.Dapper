using System;

namespace Wickers.Data.Dapper.Exceptions
{
    [Serializable]
    public class DapperException : Exception
    {
        public DapperException(){}

        public DapperException(string Message) : base(Message){}

        public DapperException(string Message, Exception InnerException) : base(Message, InnerException){}
    }
}