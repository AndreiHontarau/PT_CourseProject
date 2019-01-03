namespace Model
{
    public interface IscreenshotsRepository
    {
        void AddScreenshot(string movieID, string uploadFromPath);
        void DeleteScreenshot(string movieID);
        string GetScreenshot(string movieID);
    }
}
