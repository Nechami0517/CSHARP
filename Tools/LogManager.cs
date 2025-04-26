using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Tools
{
    public static class LogManager
    {
        private static string LogPath = "Log";
        static DirectoryInfo currentDir = new DirectoryInfo(LogPath);

        //פונקציה המחזירה ניתוב מלא של תיקייה
        public static string getFolderPath(string dirName)
        {
            DirectoryInfo currentPath = new DirectoryInfo(dirName);
            return currentPath.FullName;
        }

        //פונקציה המחזירה ניתוב מלא של קובץ
        public static string getFilePath(string dirName)
        {
            FileInfo currentPath = new FileInfo(dirName);
            return currentPath.FullName;
        }
        //פונקציה הכותבת ללוג הודעה
        public static void writeToLog(string ProjectName, string functionName, string message)
        {
            DateTime logTime = DateTime.Now;
            string pathMonth = $"{LogPath}/{logTime.Month.ToString()}";
           
            bool exists = Directory.Exists(pathMonth);
            if (!exists)
            {
                Directory.CreateDirectory(pathMonth);

            }
            string pathDate = $"{pathMonth}/{logTime.Day.ToString()}.txt";
            using (FileStream fs = new FileStream(pathDate, FileMode.Append, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine($"{logTime}\t{ProjectName}.{functionName}:\t {message}");
            }

        }


        public static void cleenLog()
        {
            List<string> listFolder = currentDir.GetDirectories().Select(d => d.Name).ToList();
            foreach (string folder in listFolder)
            {
                DateTime date = DateTime.Now;
                if (date.Month == 1)
                {
                    if (!folder.Equals("12") && !folder.Equals("1"))
                    {
                        Directory.Delete(@$"{currentDir}\{folder}", true);
                    }
                }
                else
                    if (!folder.Equals(date.Month.ToString()) && !folder.Equals($"{date.Month - 1}"))
                {
                         Directory.Delete(@$"{currentDir}\{folder}", true);
                }

            }
        }


    }
}
