using EncryptionApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Lägg till EncryptionService som en singleton-tjänst
builder.Services.AddSingleton<EncryptionService>();

var app = builder.Build();

app.MapGet("/", () => "Välkommen till API:et för rövarspråket!");

// Endpoint för kryptering
app.MapGet("/encrypt", (EncryptionService service, string input) =>
{
    return service.EncryptToRovarspraket(input);
});

// Endpoint för dekryptering
app.MapGet("/decrypt", (EncryptionService service, string input) =>
{
    return service.DecryptFromRovarspraket(input);
});

app.Run();
