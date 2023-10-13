using Back_Log.Business.Dto;
using Back_Log.SharedModule.ViewModels;
using Prism.Regions;

namespace Back_Log.VideoGameModule.ViewModels
{
    public class VideoGameDetailsViewModel : ViewModelBase, INavigationAware
    {

        private VideoGameDto _model;

        public VideoGameDto Model
        {
            get { return _model; }
            set
            {
                SetProperty(ref _model, value);
            }
        }
        public VideoGameDetailsViewModel()
        {

        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            try
            {
                if (navigationContext.Parameters.TryGetValue("VideoGameDto", out VideoGameDto selectedVideoGame))
                {
                    Model = selectedVideoGame;
                }

            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
