using CCDModInstaller.WPF.Models;


namespace CCDModInstaller.WPF.Factories
{
    class ModFactory : IModFactory
    {
        public Mod Create(string fileName)
        {
            return new Mod(fileName);
        }
    }
}
