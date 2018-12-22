namespace Model
{
    public class CategoryRecord : Record
    {
        public string name { get; private set; }
        public string symbolicCode { get; private set; }
        public short amountOfMovies { get; private set;  }

        public CategoryRecord(string name, string symbolicCode, short amountOfMovies)
        {
            this.name = name;
            this.symbolicCode = symbolicCode;
            this.amountOfMovies = amountOfMovies;
        }
    }
}