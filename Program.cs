using Microsoft.AspNetCore.Components.Forms;
using System.Diagnostics.Eventing.Reader;


//Testar att skapa dev-branch



var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Välkommen till API:et för rövarspråket!");

//Metod för kryptering till rövarspråket
string EncryptToRovarspraket(string input)
{
    string vowels = "aeiouyåäöAEIOUYÅÄÖ";
    string result = "";

    foreach (char c in input)
    {
        if (!vowels.Contains(c) && char.IsLetter(c))
        {
            result += $"{c}o{c.ToString().ToLower()}"; //Om bokstaven är en konsonant lägg till "o" och bokstaven en gång till
        }
        else
        {
            result += c;
        }
    }
    return result;
}



//Endpoint för kryptering
app.MapGet("/encrypt", (string input) =>
{
    return EncryptToRovarspraket(input);
});

app.Run();
