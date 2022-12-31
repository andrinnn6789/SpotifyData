using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SpotifyDataBackend.Model
{
    public class Track
    {
        [JsonPropertyName("endTime")]
        public DateTime EndTime { get; set; }

        [JsonPropertyName("artistName")]
        public string ArtistName { get; set; }

        [JsonPropertyName("trackName")]
        public string TrackName { get; set; }

        [JsonPropertyName("msPlayed")]
        public int MsPlayed { get; set; }
    }
}
