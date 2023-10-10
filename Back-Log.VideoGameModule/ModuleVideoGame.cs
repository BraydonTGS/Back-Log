using Back_Log.VideoGameModule.ViewModels;
using Back_Log.VideoGameModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Back_Log.VideoGameModule
{
    public class ModuleVideoGame : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("MainTreeRegion", typeof(VideoGameTree));
            regionManager.RegisterViewWithRegion("MainContentRegion", typeof(VideoGameDetails));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<VideoGameDetails, VideoGameDetailsViewModel>();
            containerRegistry.RegisterForNavigation<VideoGameTree, VideoGameTreeViewModel>();
        }
    }
}
