using Battlenet.Core;
using Battlenet.Core.Interfaces;
using Battlenet.Core.Names;
using CommunityToolkit.Mvvm.ComponentModel;
using Prism.Ioc;
using Prism.Regions;

namespace Battlenet.Forms.Local.ViewModels
{
    public class BattlenetViewModel : ObservableObject, ILoadable
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        public BattlenetViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }

        public void OnLoaded()
        {
            IRegion mainRegion = _regionManager.Regions[RegionNameManager.MainRegion];
            PrismContent loginContent = _containerProvider.Resolve<PrismContent>(ContentNameManager.Login);

            if (!mainRegion.Views.Contains(loginContent))
            {
                mainRegion.Add(loginContent);
            }
            mainRegion.Activate(loginContent);
        }
    }
}
