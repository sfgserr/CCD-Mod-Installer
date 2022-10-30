using System.Collections.Generic;
using System.Threading.Tasks;

namespace CCDModInstaller.WPF.States.ModServices
{
    interface IModService
    {
        List<string> GetSourceDirectories(string fileName);

        string GetPlayerCarsName(string fileName);
    }
}
