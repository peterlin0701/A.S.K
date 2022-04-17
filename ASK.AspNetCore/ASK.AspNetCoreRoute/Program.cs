using ASK.AspNetCoreRoute;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

Console.WriteLine("HI TESTER"); //第10題

builder.Services.AddSingleton<RouteConfig>(); //第一題
builder.Services.AddLogging();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme) //第四題
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
    options =>
    {
        options.LoginPath = new PathString("/Login"); //驗證入口
        options.AccessDeniedPath = new PathString("/403.html"); //驗證失敗導向
    });

builder.Services.AddMvc().AddJsonOptions(opt => //第5題
{
    opt.JsonSerializerOptions.PropertyNamingPolicy = null;
});

builder.Services.AddRazorPages(); //第6題
builder.Services.AddControllers(); //第7題
builder.Services.AddMvc(); //第8題
builder.Services.AddControllersWithViews(); //第9題


var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseStaticFiles(new StaticFileOptions //第3題
{
    FileProvider = new PhysicalFileProvider(Path.Join(app.Environment.ContentRootPath, "UploadFile")),
    RequestPath = "/UploadFile"
});


app.UseRouting();//TODO:add route

app.UseAuthentication(); //第四題
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
    pattern: "{controller=HellowWorld}/{action=CodeMonkey}/{id?}");//TODO:(1) 加入預設頁(進網站自動導入的第一頁) http://localhost:5179
   endpoints.MapControllerRoute(
      name: "areaRoute",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");//TODO:(2) 加入區域的路由，請讓以下網址可以正常運作: http://localhost:5179/Account/Info/Detail

});
    
//TODO:(3) 加入自訂區域的路由，請讓以下網址可以正常運作: http://localhost:5179/最新消息/Congratulations on completing an assignment

app.Run();
