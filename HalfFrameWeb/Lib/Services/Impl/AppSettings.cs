namespace HalfFrameWeb.Lib.Services.Impl
{
    public class AppSettings
    {
        private readonly IConfiguration _config;
        public AppSettings(IConfiguration config)
        {
            _config = config;
        }
        public string DbFilePath
        {
            get
            {
                return _config["App:DbFilePath"] ?? "half.db";
            }
        }
    }
}
