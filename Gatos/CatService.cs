using Newtonsoft.Json.Linq;

namespace Gatos
{
    // Classe responsável por obter imagens aleatórias de gatos da API
    public class CatService
    {
        private readonly HttpClient _httpClient;

        public CatService()
        {
            _httpClient = new HttpClient();
        }

        // Método assíncrono que retorna a URL de uma imagem aleatória de gato
        public async Task<string> GetRandomCatImageUrlAsync()
        {
            try
            {
                // Faz uma requisição GET para a API que retorna um JSON com a URL da imagem
                string response = await _httpClient.GetStringAsync("https://api.thecatapi.com/v1/images/search");

                // Converte a resposta JSON para um array usando Newtonsoft.Json
                JArray data = JArray.Parse(response);

                // Extrai a URL da imagem do primeiro item do array
                return data[0]["url"].ToString();
            }
            catch
            {
                // Lança uma exceção genérica para ser tratada no formulário
                throw new Exception("Não foi possível obter a imagem do gato.");
            }
        }
    }
}
