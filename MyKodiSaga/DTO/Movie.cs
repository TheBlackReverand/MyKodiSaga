namespace MyKodiSaga.DTO
{
    public class Movie
    {
        public int IdMovie;
        public int IdFile;
        public string Name;
        public int IdSaga;

        public Movie(int idMovie, int idFile, string name, int idSaga)
        {
            IdMovie = idMovie;
            IdFile = idFile;
            Name = name;
            IdSaga = idSaga;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}