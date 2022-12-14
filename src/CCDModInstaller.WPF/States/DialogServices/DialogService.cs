using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.Win32;


namespace CCDModInstaller.WPF.States.DialogServices
{
    class DialogService : IDialogService
    {
        private readonly CommonOpenFileDialog _commonFileDialog = new CommonOpenFileDialog();
        private readonly OpenFileDialog _fileDialog = new OpenFileDialog();

        public DialogService()
        {
            _commonFileDialog.IsFolderPicker = true;
            _fileDialog.Filter = "Archive|*.rar";
        }

        public string SelectItem(SelectType selectType)
        {
            return selectType switch
            {
                SelectType.Folder => SelectFolder(),
                _ => SelectFile()
            };
        }

        private string SelectFile()
        {
            if(_fileDialog.ShowDialog() == true) return _fileDialog.FileName;
            return "";
        }

        private string SelectFolder()
        {
            if (_commonFileDialog.ShowDialog() == CommonFileDialogResult.Ok) return _commonFileDialog.FileName;
            return "";
        }
    }
}
