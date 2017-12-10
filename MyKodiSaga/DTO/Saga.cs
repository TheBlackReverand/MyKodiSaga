namespace MyKodiSaga.DTO
{
    public class Saga
    {
        public int Id;
        public string Name;
        public bool IsPersonnalSaga;

        public Saga(int id, string name, bool isPersonnalSaga)
        {
            Id = id;
            Name = name;
            IsPersonnalSaga = isPersonnalSaga;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}