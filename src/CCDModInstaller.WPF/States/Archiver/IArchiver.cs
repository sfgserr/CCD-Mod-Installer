
using System.Collections.Generic;

namespace CCDModInstaller.WPF.States.Archiver
{
    interface IArchiver
    {
        void Unrar(string filePath, string folderPath);
    }
}
