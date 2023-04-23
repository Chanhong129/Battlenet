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
<<<<<<< HEAD
                // hi here is remote no modified
=======
                // hi here is remote 
>>>>>>> d1f143d773b66794ca7e2f204905b2bd6386d749
                loadable.OnLoaded();
                Console.WriteLine();
            }
        }
    }
}
