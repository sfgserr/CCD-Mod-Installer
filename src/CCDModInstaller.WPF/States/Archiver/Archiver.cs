using System.Linq;
using SharpCompress.Archives.Rar;
using SharpCompress.Archives;
using SharpCompress.Common;
using CCDModInstaller.WPF.Models;
using CCDModInstaller.WPF.Extensions;


namespace CCDModInstaller.WPF.States.Archiver
{
    class Archiver : IArchiver
    {
        private readonly Mod _mod;

        public Archiver(Mod mod)
        {
            _mod = mod;
        }

        public void Unrar(string filePath, string folderPath)
        { 
            using (RarArchive archive = RarArchive.Open(filePath))
            {
                archive.WriteToDirectory("D:\\", new ExtractionOptions() { ExtractFullPath=true, Overwrite=true });
                archive.Entries.ToList().ForEach((e) => e.WriteEntry(folderPath, _mod.SourceDirectories));
            }
        }
    }
}
