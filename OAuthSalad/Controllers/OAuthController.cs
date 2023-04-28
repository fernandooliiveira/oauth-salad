using System.Net;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using OAuthSalad.Model;

namespace OAuthSalad.Controllers;


[ApiController]
[Route("auth")]
public class OAuthController : Controller
{

    private readonly HttpClient _client;

    public OAuthController(HttpClient client)
    {
        _client = client;
    }
    
    [HttpGet]
    public async Task<HttpStatusCode> SignUp()
    {
        Form f = new Form(new List<Field>(new []{new Field("email", "fernandolvr49@gmail.com"), new Field("password", "pass123")}));
        var todoItemJson = new StringContent(
            JsonSerializer.Serialize(f),
            Encoding.UTF8,
            "application/json");
        
        HttpResponseMessage response = await _client.PostAsync("http://localhost:3567/recipe/signup", todoItemJson);
        return HttpStatusCode.Accepted;
    }
}