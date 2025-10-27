using Serilog;

var builder = WebApplication.CreateBuilder(args);

// ── Serilog (đọc từ appsettings nếu có, ghi console) ───────────────
builder.Host.UseSerilog((ctx, services, lc) => lc
    .ReadFrom.Configuration(ctx.Configuration)   // tùy chọn, có thể bỏ nếu chưa có Serilog trong appsettings
    .Enrich.FromLogContext()
    .WriteTo.Console());

// ── Services ────────────────────────────────────────────────────────
builder.Services.AddControllersWithViews();
builder.Services.AddHealthChecks();

var app = builder.Build();

// ── Pipeline ────────────────────────────────────────────────────────
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Health endpoint
app.MapHealthChecks("/healthz");

app.Run();
