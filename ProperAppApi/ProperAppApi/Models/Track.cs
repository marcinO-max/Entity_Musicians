using System.Collections.Generic;

namespace ProperAppApi.Models
{
    public class Track
    {
        public int IdTrack { get; set; }

        public string Trackname { get; set; }

        public float Duration { get; set; }

        public int? IdMusicAlbum { get; set; }

        public Album Album { get; set; }

        public ICollection<MusicianTrack> MusicianTracks { get; set; }
    }
}