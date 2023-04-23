using Battlenet.Core.Interfaces;
using Prism.Mvvm;
using System.Windows;
using System.Windows.Controls;

namespace Battlenet.Core
{
    public class PrismContent : ContentControl
    {
        public PrismContent()
        {
            ViewModelLocationProvider.AutoWireViewModelChanged(this, AutoWireViewModelChanged);
            Loaded += PrismContent_Loaded;
        }

        private void PrismContent_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (DataContext is ILoadable loadable)
            {
                loadable.OnLoaded();
            }
        }

        private void AutoWireViewModelChanged(object arg1, object arg2)
        {
            if (arg1 is FrameworkElement fe)
            {
                fe.DataContext = arg2;
            }
        }
    }
}
