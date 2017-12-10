using MyKodiSaga.DTO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MyKodiSaga
{
    public static class MySql
    {
        private static MySqlConnection connection;

        public static void Connect()
        {
            connection = new MySqlConnection(Params.MySqlConnectionString);

            connection.Open();
        }

        public static void SelectDataBase(string dataBaseName)
        {
            connection.ChangeDatabase(dataBaseName);
        }


        public static bool CheckIfSagaMonitoringTableExist()
        {
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SHOW TABLES LIKE 'myKodiSagaTracking'";

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }
        public static void CreateSagaMonitoringTable()
        {
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "CREATE TABLE myKodiSagaTracking (name TEXT NOT NULL)";

                command.ExecuteNonQuery();
            }
        }


        public static List<string> ListMovieDataBase
        {
            get
            {
                List<string> retour = new List<string>();

                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SHOW DATABASES LIKE 'Kodi-video%'";

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            retour.Add(reader.GetString(0));
                        }
                    }
                }

                return retour;
            }
        }

        public static List<Saga> ListSaga
        {
            get
            {
                List<Saga> retour = new List<Saga>();

                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT idSet, strSet, name IS NOT NULL " +
                                          "FROM sets " +
                                          "     LEFT JOIN myKodiSagaTracking ON name = strSet";

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            retour.Add(new Saga(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2)));
                        }
                    }
                }

                return retour.OrderBy(s => s.Name).ToList();
            }
        }
        public static List<Movie> ListFilm
        {
            get
            {
                List<Movie> retour = new List<Movie>();

                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT DISTINCT idMovie, idFile, c00 " +
                                          "FROM movie";

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            retour.Add(new Movie(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), -1));
                        }
                    }
                }

                return retour.OrderBy(m => m.Name).ToList();
            }
        }


        public static bool CreateSaga(string name)
        {
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO sets (strSet) VALUES (@strSet)";

                command.Parameters.Clear();
                command.Parameters.Add(new MySqlParameter("strSet", name));

                if (command.ExecuteNonQuery() == 1)
                {
                    command.CommandText = "INSERT INTO myKodiSagaTracking (name) VALUES (@name)";

                    command.Parameters.Clear();
                    command.Parameters.Add(new MySqlParameter("name", name));

                    return command.ExecuteNonQuery() == 1;
                }
                else
                {
                    return false;
                }
            }
        }
        public static void DeleteSaga(Saga saga)
        {
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.Parameters.Clear();
                command.Parameters.Add(new MySqlParameter("name", saga.Name));


                command.CommandText = "DELETE FROM myKodiSagaTracking WHERE name = @name";
                command.ExecuteNonQuery();

                command.CommandText = "DELETE FROM sets WHERE strSet = @name";
                command.ExecuteNonQuery();
            }
        }


        public static List<Movie> ListFilmSaga(Saga saga)
        {
            List<Movie> retour = new List<Movie>();

            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT idMovie, idFile, c00, idSet " +
                                      "FROM movie " +
                                      "WHERE idSet = @idSet";

                command.Parameters.Clear();
                command.Parameters.Add(new MySqlParameter("idSet", saga.Id));

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        retour.Add(new Movie(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3)));
                    }
                }
            }

            return retour.OrderBy(m => m.Name).ToList();
        }
    }
}