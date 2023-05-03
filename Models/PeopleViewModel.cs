using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SwapiMVC2.Models
{
    public class PeopleViewModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("height")]
        public string Height { get; set; }
        
        [JsonPropertyName("mass")]
        public string Mass { get; set; }
        
        [JsonPropertyName("birth_year")]
        // We are receiving the Json "birth-year" from the API, and here were are reassigning the name to be BirthYear on the MVC
        public string BirthYear { get; set; }
        
        [JsonPropertyName("url")]
        public string Url { get; set; }
        public string Id
        {
            get
            {
                return Url
                    .Split("/", StringSplitOptions.RemoveEmptyEntries)
                    .LastOrDefault();
                    // Grabbing the person ID from the url - spliting on "/" and grabbing the last entry that is not empty.
                    // I.E:  "https://swapit.dev.apt/people/3/"  <- 3 is Last entry since final "/" is empty. 
                    // Will now take "3" and assign it to coresponding person's ID
            }
        }
    }
}