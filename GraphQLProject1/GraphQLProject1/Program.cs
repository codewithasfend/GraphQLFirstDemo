using GraphQL.Types;
using GraphQL;
using GraphQLProject1.Repositories;
using GraphQLProject1.Type;
using GraphQLProject1.Query;
using GraphQLProject1.Schema;
using GraphiQl;
using GraphQLProject1.Mutation;
using GraphQLProject1.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApiDbContext>();

builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<BookType>();
builder.Services.AddScoped<BookInputType>();
builder.Services.AddScoped<BookQuery>();
builder.Services.AddScoped<BookMutation>();
builder.Services.AddScoped<AuthorType>();
builder.Services.AddScoped<AuthorInputType>();
builder.Services.AddScoped<AuthorQuery>();
builder.Services.AddScoped<AuthorMutation>();
builder.Services.AddScoped<RootQuery>();
builder.Services.AddScoped<RootMutation>();
builder.Services.AddScoped<ISchema, RootSchema>();

builder.Services.AddGraphQL(b => b
.AddAutoSchema<ISchema>()  // schema
.AddSystemTextJson());


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseGraphiQl("/graphql");              // url to host GraphQL endpoint
app.UseGraphQL<ISchema>();


app.UseAuthorization();

app.MapControllers();

app.Run();
