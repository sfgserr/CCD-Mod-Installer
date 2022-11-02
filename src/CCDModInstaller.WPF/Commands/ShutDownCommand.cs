using System;
using System.Windows.Input;
using System.Windows;

namespace CCDModInstaller.WPF.Commands
{
    class ShutDownCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            Application.Current.Shutdown();
        }
    }
}
