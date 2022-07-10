using RayTracing;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddCors(options => options.AddPolicy("allowAny", o => o.AllowAnyOrigin()));
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyAllowedOrigins",
        policy =>
        {
            policy.WithOrigins("https://localhost:4200") // note the port is included 
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin()
                .WithExposedHeaders("content-disposition");
        });
});
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors("MyAllowedOrigins");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.MapGet("/object/siema", () => "Sieema");
//app.MapPost("/object/sfera", (Sphere s) => "To jest sfera: " );
//app.MapPost("/object/wektor", (int a, int b, int c) => "To jest wektor: " + a );

app.MapGet("/download", () =>
{
    // Thread th = new Thread(Class1.Main);     //to nie dziala jak co
    // th.Start();
    // th.Join();
    Class1.Main();

    return Results.File(@"D:\RayTracingProject\RayTracing\obraz.png", "image/png", "obraz.png");
});

app.UseHttpsRedirection();

app.Run();
