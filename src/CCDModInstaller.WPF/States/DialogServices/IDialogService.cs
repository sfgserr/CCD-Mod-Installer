
namespace CCDModInstaller.WPF.States.DialogServices
{
    public enum SelectType
    {
        Folder,
        File
    }

    interface IDialogService
    {
        string SelectItem(SelectType selectType);
    }
}
