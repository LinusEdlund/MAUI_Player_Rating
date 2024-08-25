using PlayerRatingMaui.Model;
using PlayerRatingMaui.ViewModel;

namespace PlayerRatingMaui.View;

public partial class PlayerRatingPage : ContentPage
{
	public PlayerRatingPage(PlayerModel selectedProperty)
	{
        InitializeComponent();
        PlayerRatingViewModel viewModel = new() { SelectedProperty = selectedProperty };
        viewModel.PropertyImages = selectedProperty.Images.Take(2).ToList();
        viewModel.MoreItems = selectedProperty.Images.Count - 2;
        viewModel.AvgScore = selectedProperty.AvgScore;

        this.BindingContext = viewModel;
    }
}