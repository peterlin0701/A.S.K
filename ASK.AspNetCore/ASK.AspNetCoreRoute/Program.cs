using ASK.AspNetCoreRoute;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

Console.WriteLine("HI TESTER"); //��10�D

builder.Services.AddSingleton<RouteConfig>(); //�Ĥ@�D
builder.Services.AddLogging();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme) //�ĥ|�D
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
    options =>
    {
        options.LoginPath = new PathString("/Login"); //���ҤJ�f
        options.AccessDeniedPath = new PathString("/403.html"); //���ҥ��ѾɦV
    });

builder.Services.AddMvc().AddJsonOptions(opt => //��5�D
{
    opt.JsonSerializerOptions.PropertyNamingPolicy = null;
});

builder.Services.AddRazorPages(); //��6�D
builder.Services.AddControllers(); //��7�D
builder.Services.AddMvc(); //��8�D
builder.Services.AddControllersWithViews(); //��9�D


var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseStaticFiles(new StaticFileOptions //��3�D
{
    FileProvider = new PhysicalFileProvider(Path.Join(app.Environment.ContentRootPath, "UploadFile")),
    RequestPath = "/UploadFile"
});


app.UseRouting();//TODO:add route

app.UseAuthentication(); //�ĥ|�D
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
    pattern: "{controller=HellowWorld}/{action=CodeMonkey}/{id?}");//TODO:(1) �[�J�w�]��(�i�����۰ʾɤJ���Ĥ@��) http://localhost:5179
   endpoints.MapControllerRoute(
      name: "areaRoute",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");//TODO:(2) �[�J�ϰ쪺���ѡA�����H�U���}�i�H���`�B�@: http://localhost:5179/Account/Info/Detail

});
    
//TODO:(3) �[�J�ۭq�ϰ쪺���ѡA�����H�U���}�i�H���`�B�@: http://localhost:5179/�̷s����/Congratulations on completing an assignment

app.Run();
