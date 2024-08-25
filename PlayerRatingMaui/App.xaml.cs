using PlayerRatingMaui.View;

namespace PlayerRatingMaui;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new TeamPage());
    }
}
