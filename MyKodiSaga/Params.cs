using System.Configuration;

namespace MyKodiSaga
{
    public static class Params
    {
        public static string MySqlConnectionString = ConfigurationManager.ConnectionStrings["mySqlConnectionString"].ConnectionString;

        //public static int MySqlServerIP = ConfigurationManager.AppSettings["mysqlServerIP"];
        //public static string MySqlServerIP = ConfigurationManager.AppSettings["mysqlServerIP"];
    }
}