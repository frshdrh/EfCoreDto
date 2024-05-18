var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddInfrastructureServices();
builder.AddWebAppServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI(opt =>
	{
		opt.SwaggerEndpoint("v1/swagger.json", "EfCoreDto API v1");
		opt.RoutePrefix = "swagger";
	});
}

app.UseHttpsRedirection();

app.MapGet("/hi", () => TypedResults.Ok("Hello World!"));

await app.RunAsync();
