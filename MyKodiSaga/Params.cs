using System.Configuration;

namespace MyKodiSaga
{
    public static class Params
    {
        public static string MySqlConnectionString = ConfigurationManager.ConnectionStrings["mySqlConnectionString"].ConnectionString;
    }
}