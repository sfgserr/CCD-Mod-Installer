using System.IO.Compression;

namespace CCDModInstaller.WPF.States.Archiver
{
    class Archiver : IArchiver
    {
        public void Unzip(string filePath)
        {
            ZipFile.ExtractToDirectory(filePath, "D:\\");
        }
    }
}
