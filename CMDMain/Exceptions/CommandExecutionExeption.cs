using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CMDMain.Exceptions
{
    class CommandExecutionExeption : Exception
    {
        public CommandExecutionExeption()
        {
        }

        public CommandExecutionExeption(string message) : base(message)
        {
        }

        public CommandExecutionExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CommandExecutionExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
