using PlayerRatingMaui.ViewModel;

namespace PlayerRatingMaui.View;

public partial class TeamPage : ContentPage
{
	public TeamPage()
	{
        InitializeComponent();
        this.BindingContext = new TeamViewModel();
        ((RadioButton)SectionList.Children[0]).IsChecked = true;
    }
}