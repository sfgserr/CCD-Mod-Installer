using System.IO;

namespace CCDModInstaller.WPF.States.DirectoryServices
{
   class DirectoryService : IDirectoryService
   {
      public void MoveDirectory(string folderPath)
      {
          Directory.Move("D:\\data", $"{folderPath}");
          Directory.Move("D:\\export", $"{folderPath}");
      }
   }
}