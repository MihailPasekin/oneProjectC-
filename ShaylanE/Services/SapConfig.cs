namespace EComersWebApiEmploe.Services
{
    public class SapConfig
    {
        public string Server { get; set; }
        public string SLDServer { get; set; }
        public int DbServerType { get; set; }
        public string LicenseServer { get; set; }
        public string CompanyDB { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DbUserName { get; set; }
        public string DbPassword { get; set; }
        public int language { get; set; }
        public bool UseTrusted { get; set; }

        public SapConfig() { }

        public SapConfig(IConfiguration configuration)
        {
            Server = configuration["Server"];
            SLDServer = configuration["SLDServer"];
            DbServerType = int.Parse(configuration["DbServerType"]);
            LicenseServer = configuration["LicenseServer"];
            CompanyDB = configuration["CompanyDB"];
            UserName = configuration["SapUserName"];
            Password = configuration["Password"];
            DbUserName = configuration["DbUserName"];
            DbPassword = configuration["DbPassword"];
            language = int.Parse(configuration["language"]);
            UseTrusted = bool.Parse("true");
        }

        public class LoggingVal
        {
            public LogLevelVal LogLevel { get; set; }
            public LoggingVal()
            {
                LogLevel = new LogLevelVal();
            }
            public class LogLevelVal
            {
                public string Default { get; set; } = "Information";
                public string Microsoft { get; set; } = "Warning";
                public string Microsoft_Hosting_Lifetime { get; set; } = "Information";
            }
        }
    }
}
