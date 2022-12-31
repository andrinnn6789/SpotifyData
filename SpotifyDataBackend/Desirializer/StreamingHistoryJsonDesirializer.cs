using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpotifyDataBackend.Model;

namespace SpotifyDataBackend.Desirializer
{
    public static class StreamingHistoryJsonDesirializer
    {
        public static IEnumerable<Track> ProvideTracksFromJson(string directoryPath)
        {
            var json = string.Empty;
            var index = 0;
            var fullPath = Path.GetFullPath(directoryPath);
            var path = GetCurrentPath(fullPath, index);
            var tracks = new List<Track>();

            while (File.Exists(path))
            {
                using StreamReader r = new(path);
                json = r.ReadToEnd();
                var jsonTracks = JsonConvert.DeserializeObject<IEnumerable<Track>>(json)!.ToList();
                tracks.AddRange(jsonTracks);
                index++;
                path = GetCurrentPath(fullPath, index);
            }

            return tracks;
        }

        private static string GetCurrentPath(string directoryPath, int index)
        {
            return directoryPath + "\\StreamingHistory" + index + ".json";
        }
    }
}
