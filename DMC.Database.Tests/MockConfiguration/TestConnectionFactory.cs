using DMC.Database.Configuration;

namespace DMC.Database.Tests.MockConfiguration
{
    public static class TestConnectionFactory
    {
        public static ConnectionInfo GetConnectionInfo()
        {
            return new ConnectionInfo
            {
                DatabaseType = DatabaseType.SqlServer,
                ServerAddress = "XAVIER\\MusicDB",
                ServerPort = 1433,
                DatabaseName = "DMCIntegration",
                Username = "dmctest",
                Password = "dmc123"
            };
        }
    }
}
