
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace ScreenSound.Utilits;

internal class OpenRouterAPI
{

    private static readonly string API_KEY = "SUA_CHAVE_DE_API";

    private static readonly HttpClient http = new HttpClient();

    public static async Task<string> ChamarAsync(string prompt)
    {
        var url = "https://openrouter.ai/api/v1/chat/completions";

        var payload = new
        {
            
            messages = new[]
            {
                new { role = "user", content = prompt }
            }
        };

        var json = JsonSerializer.Serialize(payload);

        var request = new HttpRequestMessage(HttpMethod.Post, url);
        request.Content = new StringContent(json, Encoding.UTF8, "application/json");

        // Headers obrigatórios — AGORA FUNCIONAM
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", API_KEY);


        var response = await http.SendAsync(request);
        var responseString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception("Erro OpenRouter (" + response.StatusCode + "):\n" + responseString);
        }

        using var doc = JsonDocument.Parse(responseString);
        string text =
            doc.RootElement.GetProperty("choices")[0]
            .GetProperty("message")
            .GetProperty("content")
            .GetString();

        return text;
    }

}
