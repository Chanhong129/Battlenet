using Battlenet.Core;
using System.Windows;

namespace Battlenet.Login.UI.Views
{
    public class LoginContent : PrismContent
    {
        static LoginContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LoginContent), new FrameworkPropertyMetadata(typeof(LoginContent)));
        }
    }
}
