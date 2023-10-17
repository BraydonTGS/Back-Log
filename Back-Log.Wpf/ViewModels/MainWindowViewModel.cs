using Back_Log.Global.Constants;
using Back_Log.SharedModule.ViewModels;
using Prism.Commands;
using System;

namespace Back_Log.Wpf.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _username;

        public string Username
        {
            get { return _username; }
            set
            {
                SetProperty(ref _username, value);
            }
        }

        public DelegateCommand MinimizeWindowCommand { get; set; }
        public DelegateCommand CloseWindowCommand { get; set; }

        public MainWindowViewModel()
        {
            Title = Constants.Title;

            MinimizeWindowCommand = new DelegateCommand(OnMinimizeWindowCommandExecuted);
            CloseWindowCommand = new DelegateCommand(OnCloseWindowCommandExecuted);

            Username = Environment.UserDomainName;

        }

        #region Commands
        private void OnCloseWindowCommandExecuted()
        {
            App.Current.MainWindow.Close();
        }

        private void OnMinimizeWindowCommandExecuted()
        {
            App.Current.MainWindow.WindowState = System.Windows.WindowState.Minimized;
        }
        #endregion
    }
}
