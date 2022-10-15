using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace CCDModInstaller.WPF.States.PlayerCarsServices
{
    class PlayerCarService : IPlayerCarService
    {
        public void AddNewCar(string folderPath)
        {
            List<string> lines = File.ReadAllLines($"{folderPath}\\data\\config\\player_cars.xml").ToList();
            lines.Insert(lines.Count - 2, GetNewCar());
            File.WriteAllLines($"{folderPath}\\data\\config\\player_cars.xml", lines);
        }

        private string GetNewCar()
        {
            string fileName = Directory.GetFiles("D:\\Мод\\data\\config\\user_cars")[0];
            string[] lines = File.ReadAllLines(fileName);

            return string.Join(" ", lines);
        }
    }
}