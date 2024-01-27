namespace ApiLavanderia.DAO
{
    public class ConexionBD
    {
        private string linkConn = string.Empty; 

        public ConexionBD()
        {
            var constructor = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            linkConn = constructor.GetSection("ConnectionStrings:LavanderiaConn").Value;
        }

        public string LinkBD()
        {
            return linkConn;
        }
    }
}
