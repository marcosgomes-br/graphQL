using GraphQL.API;
using GraphQL.API.Queries;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddGraphQLServer().AddQueryType<ProdutoQuery>().AddProjections().AddFiltering().AddSorting();
builder.Services.AddDbContext<ApiContext>(opt => opt.UseInMemoryDatabase("graphQL"));

var app = builder.Build();

app.MapGraphQL("/graphQL");

app.UseHttpsRedirection();
app.Run();

