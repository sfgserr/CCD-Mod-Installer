using System.Linq;
using System.IO;
using SharpCompress.Archives.Rar;
using SharpCompress.Archives;
using SharpCompress.Common;

namespace CCDModInstaller.WPF.States.Archiver
{
    class Archiver : IArchiver
    {
        public void Unrar(string filePath, string folderPath)
        { 
            using (RarArchive archive = RarArchive.Open(filePath))
            {
                archive.WriteToDirectory("D:\\", new ExtractionOptions() { ExtractFullPath=true, Overwrite=true });

                foreach(var entry in archive.Entries)
                {
                    string destDir = string.Join("\\", entry.Key.Split("\\").ToList().Where(c => c != "Мод"));
                    string dir = Path.GetDirectoryName($"{folderPath}\\{destDir}");

                    if (!$"{folderPath}\\{destDir}".Contains('.')) continue;
                    if(!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                    entry.WriteToFile($"{folderPath}\\{destDir}");
                }
            }
        }
    }
}
