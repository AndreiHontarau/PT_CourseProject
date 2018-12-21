namespace Model
{
    public class MovieRecordExtended
    {
        public string ActorsList { get; private set; }
        public string CountryMade { get; private set; }
        public bool AgeRestriction { get; private set; }
        public string Language { get; private set; }
        public string Annotation { get; private set; }

        public MovieRecordExtended(string actorsList, string countryMade, bool ageRestriction,
            string language, string annotation)
        {
            ActorsList = actorsList;
            CountryMade = countryMade;
            AgeRestriction = ageRestriction;
            Language = language;
            Annotation = annotation;
        }
    }
}
