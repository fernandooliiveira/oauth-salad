var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.Services.AddAuthentication(
//     options => { options.DefaultAuthenticateScheme = "SuperToken"; }).AddOAuth(
//     "SuperToken", options =>
//     {
//         //TODO: Implementar o callback correto
//         options.CallbackPath = "/OAuth";
//         //TODO: Implementar o client id correto
//         options.ClientId = "101010";
//         //TODO: Implementar o client secret correto
//         options.ClientSecret = "lkajdlka10";
//         //TODO: Implementar o client auth end point correto
//         options.AuthorizationEndpoint = "/End";
//         //TODO: Implementar o client token end point correto
//         options.TokenEndpoint = "/token";
//     }
// );

builder.Services.AddHttpClient();

builder.Services.AddHttpContextAccessor().AddControllersWithViews();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();