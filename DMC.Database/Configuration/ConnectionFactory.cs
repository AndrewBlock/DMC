using ServiceStack.OrmLite;

namespace DMC.Database.Configuration
{
    public class ConnectionFactory : OrmLiteConnectionFactory
    {
        public ConnectionFactory(ConnectionInfo connectionInfo)
        {
            InitializeConnectionFactory(connectionInfo);
        }

        private void InitializeConnectionFactory(ConnectionInfo connectionInfo)
        {

        }
    }
}
