using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;

namespace iosStatusbarColor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.Behaviors.Add(new StatusBarBehavior
            {
                StatusBarColor = Colors.Red,
                StatusBarStyle = StatusBarStyle.DarkContent
            });
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://github.com/dotnet/maui", BrowserLaunchMode.SystemPreferred);
        }
    }

}
