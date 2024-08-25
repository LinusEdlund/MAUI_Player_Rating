

using PlayerRatingMaui.Model;
using PlayerRatingMaui.View;
using System.Windows.Input;

namespace PlayerRatingMaui.ViewModel;
public class TeamViewModel : BaseViewModel
{
    public List<string> Sections => new List<string> { "Players", "Matches", "Tabel", "Transfers" };

    public List<PlayerModel> Properties => TestDataPlayerRepo.AllProperties;

    public PlayerModel SelectedProperty { get; set; }

    public ICommand PropertySelected => new Command(obj =>
    {
        if (SelectedProperty != null)
            Application.Current.MainPage.Navigation.PushAsync(new PlayerRatingPage(SelectedProperty));

        SelectedProperty = null;
    });
}
