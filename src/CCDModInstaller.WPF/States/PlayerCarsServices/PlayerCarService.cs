using CCDModInstaller.WPF.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace CCDModInstaller.WPF.States.PlayerCarsServices
{
    class PlayerCarService : IPlayerCarService
    {
        private readonly Mod _mod;

        public PlayerCarService(Mod mod)
        {
            _mod = mod;
        }

        public void AddNewCar(string folderPath)
        {
            List<string> lines = File.ReadAllLines($"{folderPath}\\data\\config\\player_cars.xml").ToList();
            lines.Insert(lines.Count - 2, GetNewCar());
            File.WriteAllLines($"{folderPath}\\data\\config\\player_cars.xml", lines);
        }

        private string GetNewCar()
        {
            string[] lines = File.ReadAllLines($"D:\\{_mod.PlayerCarsName}");
            return string.Join(" ", lines);
        }
    }
}