using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace crafts.WebSite.Models
{
    public class Product
    {
        public string Id { get; set; } = default!;
        public string Maker { get; set; } = default!;
        [JsonPropertyName("img")]
        public string Image { get; set; } = default!;
        public string Url { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public int[] Ratings { get; set; } = default!;

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}