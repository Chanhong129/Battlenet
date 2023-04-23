using Battlenet.Core.Interfaces;
using System;
using System.Windows;

namespace Battlenet.Forms.UI.Views
{
    public class BattlenetWindow : Window
    {
        static BattlenetWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BattlenetWindow), new FrameworkPropertyMetadata(typeof(BattlenetWindow)));
        }

        public BattlenetWindow()
        {
            Loaded += BattlenetWindow_Loaded;
        }

        private void BattlenetWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is ILoadable loadable)
            {
                // hi here is remote no modified
                loadable.OnLoaded();
                Console.WriteLine();
            }
        }
    }
}
