
using System.Collections.Generic;

namespace CCDModInstaller.WPF.States.Archivers
{
    interface IArchiver
    {
        void Unrar(string filePath, string folderPath);
    }
}
