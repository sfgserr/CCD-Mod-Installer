using SharpCompress.Archives;
using SharpCompress.Archives.Rar;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace CCDModInstaller.WPF.Extensions
{
    static class WriteEntryExtension
    {
        public static void WriteEntry(this RarArchiveEntry e, string folderPath, List<string> sourceDirectories)
        {
            string destDir = string.Join("\\", e.Key.Split("\\").ToList().Where(c => !sourceDirectories.Any(x => x == c)));
            string dir = Path.GetDirectoryName($"{folderPath}\\{destDir}");

            if (!$"{folderPath}\\{destDir}".Contains('.')) return;
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            e.WriteToFile($"{folderPath}\\{destDir}");
        }
    }
}
