namespace DMC.Database.Configuration
{
    public class ConnectionInfo
    {
        public DatabaseType DatabaseType { get; set; }
        public string ServerAddress { get; set; }
        public int ServerPort { get; set; }
        public string DatabaseName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
