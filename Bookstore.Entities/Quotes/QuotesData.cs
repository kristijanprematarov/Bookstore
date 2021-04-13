using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Bookstore.Entities.Quotes
{
    public class QuotesData
    {
        [JsonPropertyName("quotes")]
        public List<Quote> Quotes { get; set; }
    }
}
