using RayTracing;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyAllowedOrigins",
        policy =>
        {
            policy.WithOrigins("https://localhost:4200") 
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin()
                .WithExposedHeaders("content-disposition");
        });
});

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


app.MapGet("/download", () =>
{
    Thread th = new Thread(Class1.fun);     
    th.Start();
    th.Join();

    return Results.File("D:\\RayTracingProject\\RayTracing\\WebApplication1\\obraz.png", "image/png", "obraz.png");
});


app.UseHttpsRedirection();

app.Run();
