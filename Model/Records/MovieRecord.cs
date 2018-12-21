namespace Model
{
    public class MovieRecord : Record
    {
        public string MovieID { get; private set; }
        public short CategoryID { get; private set; }
        public string Category { get; private set; }
        public string Title { get; private set; }
        public string Producer { get; private set; }
        public short Year { get; private set; }
        public string Carrier { get; private set; }
        public short AmountOfCopies { get; private set; }

        public MovieRecord(string movieID, short categoryID, string title, short year, string producer,
            string carrier, short amountOfCopies, string category = null)
        {
            Category = category;
            MovieID = movieID;
            CategoryID = categoryID;
            Title = title;
            Producer = producer;
            Year = year;
            Carrier = carrier;
            AmountOfCopies = amountOfCopies;
        }
    }
}
