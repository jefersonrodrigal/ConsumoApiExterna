using System.Text.Json.Serialization;

namespace APIConsumoExternalApi.ViewModels
{
    public class CepViewModel
    {
        [JsonPropertyName("cep")]
        public string Cep { get; set; }
        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }
        [JsonPropertyName("localidade")]
        public string Localidade { get; set; }
    }
}
