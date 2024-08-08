using APIConsumoExternalApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace APIConsumoExternalApi.Controllers
{
    [ApiController]
    public class RequestController : ControllerBase
    {
        [HttpGet("/cep/{cep}")]
        public async Task<IActionResult> GetAddress(string cep)
        {
            var url = $"https://viacep.com.br/ws/{cep}/json/";
            var client = new HttpClient();
            try
            {
                HttpResponseMessage resp = await client.GetAsync(url);
                resp.EnsureSuccessStatusCode();
                var respContent = await resp.Content.ReadAsStringAsync();
                var respCep = JsonSerializer.Deserialize<CepViewModel>(respContent);

                return Ok(respCep);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
