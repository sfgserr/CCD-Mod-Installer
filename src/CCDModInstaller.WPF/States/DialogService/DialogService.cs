using Microsoft.WindowsAPICodePack.Dialogs;

namespace CCDModInstaller.WPF.States.DialogService
{
    class DialogService : IDialogService
    {
        private readonly CommonOpenFileDialog _fileDialog;

        public DialogService(CommonOpenFileDialog fileDialog)
        {
            _fileDialog = fileDialog;
            _fileDialog.IsFolderPicker = true;
        }

        public string SelectFolder()
        {
            if (_fileDialog.ShowDialog() == CommonFileDialogResult.Ok) return _fileDialog.FileName;
            return "";
        }
    }
}
