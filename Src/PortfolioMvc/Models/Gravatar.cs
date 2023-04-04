using Newtonsoft.Json;

namespace PortfolioMvc.Models
{
    // Gravatar myDeserializedClass = JsonConvert.DeserializeObject<Gravatar>(myJsonResponse);
    public class Email
    {
        [JsonProperty("primary")]
        public string Primary { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Entry
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("requestHash")]
        public string RequestHash { get; set; }

        [JsonProperty("profileUrl")]
        public string ProfileUrl { get; set; }

        [JsonProperty("preferredUsername")]
        public string PreferredUsername { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("photos")]
        public List<Photo> Photos { get; set; }

        [JsonProperty("profileBackground")]
        public ProfileBackground ProfileBackground { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("aboutMe")]
        public string AboutMe { get; set; }

        [JsonProperty("currentLocation")]
        public string CurrentLocation { get; set; }

        [JsonProperty("phoneNumbers")]
        public List<PhoneNumber> PhoneNumbers { get; set; }

        [JsonProperty("emails")]
        public List<Email> Emails { get; set; }

        [JsonProperty("ims")]
        public List<Im> Ims { get; set; }

        [JsonProperty("urls")]
        public List<Url> Urls { get; set; }
    }

    public class Im
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Name
    {
        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("formatted")]
        public string Formatted { get; set; }
    }

    public class PhoneNumber
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Photo
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ProfileBackground
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Gravatar
    {
        [JsonProperty("entry")]
        public List<Entry> Entry { get; set; }
    }

    public class Url
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }


}