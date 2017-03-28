
using Newtonsoft.Json;

namespace VirtoCommerce.ProductRecommendationsModule.Core.Model
{
    public class RecommendedItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }
    }
}