using Prism.Mvvm;

namespace Back_Log.SharedModule.ViewModels
{
    public class ViewModelBase : BindableBase
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}
