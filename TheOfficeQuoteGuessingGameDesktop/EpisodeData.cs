using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TheOfficeQuoteGuessingGameDesktop
{
    public class EpisodeData
    {
        public int Season { get; set; }       


        public int Episode {  get; set; }


        [JsonPropertyName("episode_name")]
        public string Title { get; set; }

        public string Character {  get; set; }

        public string Quote { get; set; }
    }
}
