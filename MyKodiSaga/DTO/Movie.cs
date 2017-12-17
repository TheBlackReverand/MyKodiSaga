using System;

namespace MyKodiSaga.DTO
{
    public class Movie
    {
        public int IdMovie;
        public int IdFile;
        public string Name;

        public int IdSaga;
        public string SagaName;

        public Movie(int idMovie, int idFile, string name, int idSaga, string sagaName)
        {
            IdMovie = idMovie;
            IdFile = idFile;
            Name = name;

            IdSaga = idSaga;
            SagaName = sagaName;
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(SagaName))
            {
                return Name;
            }
            else
            {
                return Name + " (" + SagaName + ")";
            }
        }
    }
}