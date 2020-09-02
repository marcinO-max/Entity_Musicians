using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProperAppApi.Exceptions
{
    public class MusicianReleaseAlbumException : Exception
    {
        public MusicianReleaseAlbumException()
        {
        }

        public MusicianReleaseAlbumException(string message) : base(message)
        {
        }

        public MusicianReleaseAlbumException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
