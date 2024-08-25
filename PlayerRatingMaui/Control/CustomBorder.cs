

using Microsoft.Maui.Controls.Shapes;

namespace PlayerRatingMaui.Control;
public class CustomBorder : Border
{
    public CustomBorder()
    {
        TranslationX = new Random().Next(-500, 500);
        Rotation = Math.Max(TranslationX, 100);

        AddCornerRadius();

        Loaded += (s, e) =>
        {
            this.TranslateTo(0, 0, 1500, Easing.SinInOut);
            this.RotateTo(0, 1500, Easing.SinInOut);
        };
    }

    private List<int> _cornerValues = new List<int>() { 10, 40, 70, 100 };

    private void AddCornerRadius()
    {
        var index = new Random().Next(4);

        StrokeShape = new RoundRectangle
        {
            CornerRadius = new CornerRadius(_cornerValues[index])
        };


    }
}
