using CCDModInstaller.WPF.States.ModServices;
using System.Collections.Generic;

namespace CCDModInstaller.WPF.Models
{
    class Mod : Model
    {
        private readonly IModService _modService = new ModService();

        public Mod(string fileName)
        {
            SourceDirectories = _modService.GetSourceDirectories(fileName);
            PlayerCarsName = _modService.GetPlayerCarsName(fileName);
        }

        public List<string> SourceDirectories { get; set; }
        public string PlayerCarsName { get; set; }
    }
}
