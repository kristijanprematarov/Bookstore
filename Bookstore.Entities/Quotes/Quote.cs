namespace Bookstore.Entities.Quotes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.Json.Serialization;
    public class Quote
    {
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        public string quote { get; set; }

        public string lang { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }
    }
}