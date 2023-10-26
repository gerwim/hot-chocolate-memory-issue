using System.Text.Encodings.Web;
using HotChocolate.AspNetCore.Serialization;
using HotChocolate.Execution.Serialization;
using Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddHttpResponseFormatter(new HttpResponseFormatterOptions()
{
    Json = new JsonResultFormatterOptions()
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    }
});
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

app.MapControllers();
app.MapGraphQL();

app.Run();