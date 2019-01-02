using System.IO;

namespace Model
{
    public class ScreenshotsManager : IscreenshotsRepository
    {
        private const string workingDirectory = @"Screenlists\";

        public void AddScreenshot(string movieID, string uploadFromPath)
        {
            PrepareWorkingDirectory();

            FileInfo screenshot = new FileInfo(uploadFromPath);

            screenshot.CopyTo(workingDirectory + @"\" + movieID + @".png", true);
        }

        public void DeleteScreenshot(string movieID)
        {
            FileInfo screenshot = new FileInfo(workingDirectory + @"\" + movieID + @".png");

            screenshot.Delete();
        }

        private void PrepareWorkingDirectory()
        {
            if (Directory.Exists(workingDirectory))
            {
                return;
            }
            else
            {
                Directory.CreateDirectory(workingDirectory);
            }
        }
    }
}
