namespace Model
{
    public class MovieRecord : Record
    {
        //public int CategoryID { get; private set; }
        public string MovieID { get; private set; }
        public string Category { get; private set; }
        public string Title { get; private set; }
        public string Producer { get; private set; }
        public short Year { get; private set; }
        public string Carrier { get; private set; }
        public short AmountOfCopies { get; private set; }

        public MovieRecord(/*int categoryID,*/ string movieID, string category, string title, short year, string producer,
            string carrier, short amountOfCopies)
        {
            //CategoryID = categoryID;
            Category = category;
            MovieID = movieID;
            Title = title;
            Producer = producer;
            Year = year;
            Carrier = carrier;
            AmountOfCopies = amountOfCopies;
        }

        public MovieRecord(/*int CategoryID,*/ string category, string title, short year, string producer,
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
