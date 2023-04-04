using Newtonsoft.Json;

namespace PortfolioMvc;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Logging
    {
        [JsonProperty("LogLevel")]
        public LogLevel LogLevel { get; set; }
    }

    public class LogLevel
    {
        [JsonProperty("Default")]
        public string Default { get; set; }

        [JsonProperty("Microsoft.AspNetCore")]
        public string MicrosoftAspNetCore { get; set; }
    }

    public class Settings
    {
        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("SENDGRID_API_KEY")]
        public string SENDGRIDAPIKEY { get; set; }

        [JsonProperty("SENDGRID_FROM")]
        public string SENDGRIDFROM { get; set; }

        [JsonProperty("SENDGRID_NOME")]
        public string SENDGRIDNOME { get; set; }

        [JsonProperty("Logging")]
        public Logging Logging { get; set; }

        [JsonProperty("Squidex")]
        public Squidex Squidex { get; set; }

        [JsonProperty("AllowedHosts")]
        public string AllowedHosts { get; set; }
    }

    public class Squidex
    {
        [JsonProperty("SquidexClientId")]
        public string SquidexClientId { get; set; }

        [JsonProperty("SquidexClientSecret")]
        public string SquidexClientSecret { get; set; }

        [JsonProperty("SquidexBaseUrl")]
        public string SquidexBaseUrl { get; set; }

        [JsonProperty("SquidexApp")]
        public string SquidexApp { get; set; }
    }

