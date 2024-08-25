

using PlayerRatingMaui.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PlayerRatingMaui.ViewModel;
public class PlayerRatingViewModel
{
    public PlayerModel SelectedProperty { get; set; }
    public List<string> PropertyImages { get; set; }
    public int MoreItems { get; set; }
    public double AvgScore { get; set; }
    public ObservableCollection<int> ButtonNumbers { get; set; }
    public ICommand ButtonCommand { get; }

    public PlayerRatingViewModel()
    {
        ButtonNumbers = new ObservableCollection<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        ButtonCommand = new Command<int>(OnButtonClicked);
    }

    private void OnButtonClicked(int number)
    {
        // Get the avg score and add this number on it 
        // then display it in "Details" circle 
    }
}
