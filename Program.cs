using GuestBook.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Регистрация сервисов Azure Storage
builder.Services.AddSingleton<TableStorageService>();
builder.Services.AddSingleton<BlobStorageService>();
builder.Services.AddSingleton<QueueStorageService>();

builder.Services.AddRazorPages();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();

app.Run();