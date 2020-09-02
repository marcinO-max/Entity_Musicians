using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProperAppApi.Exceptions
{
    public class MusicLabelNotFoundException : Exception
    {
        public MusicLabelNotFoundException()
        {
        }

        public MusicLabelNotFoundException(string message) : base(message)
        {
        }

        public MusicLabelNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
