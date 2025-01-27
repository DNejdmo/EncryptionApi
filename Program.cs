using Microsoft.AspNetCore.Components.Forms;
using System.Diagnostics.Eventing.Reader;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "V�lkommen till API:et f�r r�varspr�ket!");

//Metod f�r kryptering till r�varspr�ket
string EncryptToRovarspraket(string input)
{
    string vowels = "aeiouy���AEIOUY���";
    string result = "";

    foreach (char c in input)
    {
        if (!vowels.Contains(c) && char.IsLetter(c))
        {
            result += $"{c}o{c.ToString().ToLower()}"; //Om bokstaven �r en konsonant l�gg till "o" och bokstaven en g�ng till
        }
        else
        {
            result += c;
        }
    }
    return result;
}



//Endpoint f�r kryptering
app.MapGet("/encrypt", (string input) =>
{
    return EncryptToRovarspraket(input);
});

app.Run();
