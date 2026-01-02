using Microsoft.AspNetCore.ResponseCompression;

namespace HalfFrameWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddRazorPages();

            if (!builder.Environment.IsDevelopment())
            {
                builder.Services.AddResponseCompression(options =>
                {
                    options.EnableForHttps = true;
                    options.Providers.Add<GzipCompressionProvider>();
                    options.Providers.Add<BrotliCompressionProvider>();
                });
            }

            var app = builder.Build();

            app.UseRouting();
            app.UseAuthorization();
            if (!app.Environment.IsDevelopment())
            {
                app.UseResponseCompression();
            }
            app.UseStaticFiles(new StaticFileOptions()
            {
                RequestPath = "/static"
            });
            app.MapRazorPages();

            app.Run();
        }
    }
}
