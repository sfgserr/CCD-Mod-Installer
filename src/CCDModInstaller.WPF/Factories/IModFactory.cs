using CCDModInstaller.WPF.Models;


namespace CCDModInstaller.WPF.Factories
{
    interface IModFactory
    {
        Mod Create(string filePath);
    }
}
