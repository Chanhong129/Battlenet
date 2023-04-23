using Battlenet.Core;
using Battlenet.Core.Names;
using Battlenet.Forms.Local.ViewModels;
using Battlenet.Forms.UI.Views;
using Battlenet.Login.Local.ViewModels;
using Battlenet.Login.UI.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Unity;
using System.Collections.Generic;
using System.Windows;

namespace Battlenet
{
    internal class App : PrismApplication
    {
        private List<IModule> _modules;

        public App()
        {
            _modules = new();
        }

        protected override Window CreateShell()
        {
            return new BattlenetWindow();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Singleton
            containerRegistry.RegisterSingleton<PrismContent, LoginContent>(ContentNameManager.Login);
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);

            foreach (var module in _modules)
            {
                moduleCatalog.AddModule(module.GetType());
            }
        }

        internal App AddModule<T>() where T : IModule, new()
        {
            _modules.Add(new T());
            return this;
        }

        internal App WireViewModel()
        {
            ViewModelLocationProvider.Register<BattlenetWindow, BattlenetViewModel>();
            ViewModelLocationProvider.Register<LoginContent, LoginContentViewModel>();
            return this;
        }
    }
}
