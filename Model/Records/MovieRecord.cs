namespace Model
{
    public class MovieRecord : Record
    {
        public string MovieID { get; private set; }
        public string Category { get; private set; }
        public string Title { get; private set; }
        public string Producer { get; private set; }
        public short Year { get; private set; }
        public string Carrier { get; private set; }
        public short AmountOfCopies { get; private set; }

        public MovieRecord(string movieID, string category, string title, short year, string producer,
            string carrier, short amountOfCopies)
        {
            MovieID = movieID;
            Category = category;
            Title = title;
            Producer = producer;
            Year = year;
            Carrier = carrier;
            AmountOfCopies = amountOfCopies;
        }

        public MovieRecord(string category, string title, short year, string producer,
            string carrier, short amountOfCopies)
        {
            Category = category;
            Title = title;
            Producer = producer;
            Year = year;
            Carrier = carrier;
            AmountOfCopies = amountOfCopies;
        }
    }
}
