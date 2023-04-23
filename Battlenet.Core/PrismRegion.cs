using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace Battlenet.Core
{
    public class PrismRegion : ContentControl
    {
        public string RegionName
        {
            get { return (string)GetValue(RegionNameProperty); }
            set { SetValue(RegionNameProperty, value); }
        }

        public static readonly DependencyProperty RegionNameProperty =
            DependencyProperty.Register("RegionName", typeof(string), typeof(PrismRegion), new PropertyMetadata(RegionPropertyChanged));

        private static void RegionPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(e.NewValue is string str
                && string.IsNullOrEmpty(str) == false
                && Application.Current?.CheckAccess() == true)
            {
                IRegionManager rm = RegionManager.GetRegionManager(Application.Current.MainWindow);
                RegionManager.SetRegionName((PrismRegion)d, str);
                RegionManager.SetRegionManager(d, rm);
            }
        }
    }
}
