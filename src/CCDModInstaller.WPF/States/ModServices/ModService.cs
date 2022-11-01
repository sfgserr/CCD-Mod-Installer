using SharpCompress.Archives.Rar;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CCDModInstaller.WPF.States.ModServices
{
    class ModService : IModService
    {
        public List<string> GetSourceDirectories(string filePath)
        {
            using(RarArchive archive = RarArchive.Open(filePath))
            {
                string keys = GetFirstKey(filePath);
                return keys.Split("\\").TakeWhile(d => d != "data").ToList();
            }
        }

        public string GetPlayerCarsName(string filePath)
        {
            using(RarArchive archive = RarArchive.Open(filePath))
            {
                string sourceDirectories = string.Join("\\", GetSourceDirectories(filePath));
                string name = $"{sourceDirectories}\\data\\config\\user_cars";

                if (archive.Entries.Any(e => e.Key == name)) return Directory.GetFiles(name)[0];
                return archive.Entries.Where(e => e.Key.Contains(".") && e.Key.Split(".")[1] == "txt").ToList()[0].Key;
            }
        }

        private string GetFirstKey(string filePath)
        {
            using(RarArchive archive = RarArchive.Open(filePath))
            {
                return archive.Entries.FirstOrDefault(e => e.Key.Split("\\").Contains("data")).Key;
            }
        }
    }
}
