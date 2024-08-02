WebApplicationBuilder webApplicationBuilder = WebApplication.CreateBuilder(args);

webApplicationBuilder.Services.AddRazorPages();
webApplicationBuilder.Services.AddSession();

WebApplication webApplication = webApplicationBuilder.Build();

if (!webApplication.Environment.IsDevelopment()) webApplication.UseExceptionHandler("/Error");

webApplication.UseSession();
webApplication.UseStaticFiles();
webApplication.UseRouting();
webApplication.UseAuthorization();
webApplication.MapRazorPages();
webApplication.Run();


