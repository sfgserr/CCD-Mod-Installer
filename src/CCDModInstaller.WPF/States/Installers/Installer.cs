using CCDModInstaller.WPF.Models;
using CCDModInstaller.WPF.States.Archivers;
using CCDModInstaller.WPF.States.PlayerCarsServices;


namespace CCDModInstaller.WPF.States.Installers
{
    class Installer : IInstaller
    {
        private IArchiver _archiver;
        private IPlayerCarService _playerCarService;

        public void Install(string filePath, string folderPath)
        {
            Set(filePath);
            
            _archiver.Unrar(filePath, folderPath);
            _playerCarService.AddNewCar(folderPath);
        }

        private void Set(string filePath)
        {
            Mod mod = new Mod(filePath);
            _archiver = new Archiver(mod);
            _playerCarService = new PlayerCarService(mod);
        }
    }
}
