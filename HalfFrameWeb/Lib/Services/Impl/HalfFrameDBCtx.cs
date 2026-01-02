using Microsoft.EntityFrameworkCore;

namespace HalfFrameWeb.Lib.Services.Impl
{
    public class HalfFrameDBCtx : DbContext
    {
        private readonly AppSettings _appSettings;
        public HalfFrameDBCtx(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={_appSettings.DbFilePath}");
        }
    }
}
