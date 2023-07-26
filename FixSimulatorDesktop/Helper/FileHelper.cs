using System.Text;

namespace FixSimulatorDesktop.Helper
{
    public static class FileHelper
    {
        public static string GetFileContents(string filename)
        {
            try
            {
                return File.ReadAllText(filename, Encoding.UTF8);
            }
            catch
            {
                return "";
            }
        }

        public static void SaveContentToFile(string contents, string filename)
        {
            File.WriteAllText(filename, contents, Encoding.UTF8);
        }

        public static void DeleteFiles(string path)
        {
            try
            {
                var di = new DirectoryInfo(path);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
            }
            catch
            {
                //NOTHING TO DO
            }
        }
    }
}
