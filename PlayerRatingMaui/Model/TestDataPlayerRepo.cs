

namespace PlayerRatingMaui.Model;
public class TestDataPlayerRepo
{
    public static List<PlayerModel> AllProperties => new List<PlayerModel>
    {
        new PlayerModel
        {
            PlayerName = "Saka",
            AvgScore = 9.1,
            DefaultImage = "https://pbs.twimg.com/media/GVMfkYZWYAA99D-?format=jpg&name=small",
            Images = new List<string>
            {
                "https://pbs.twimg.com/media/GVMfkYZWYAA99D-?format=jpg&name=small",
                "https://pbs.twimg.com/media/GVMfkYZWYAA99D-?format=jpg&name=small",
                "https://pbs.twimg.com/media/GVMfkYZWYAA99D-?format=jpg&name=small"
            }
        },
        new PlayerModel
        {
            PlayerName = "Havertz",
            AvgScore = 8.5,
            DefaultImage = "https://pbs.twimg.com/media/GVNsgSiWYAABXB7?format=jpg&name=small",
            Images = new List<string>
            {
                "https://pbs.twimg.com/media/GVNsgSiWYAABXB7?format=jpg&name=small",
                "https://pbs.twimg.com/media/GVNsgSiWYAABXB7?format=jpg&name=small",
                "https://pbs.twimg.com/media/GVNsgSiWYAABXB7?format=jpg&name=small"
            }
        },
        new PlayerModel
        {
            PlayerName = "Raya",
            AvgScore = 8.3,
            DefaultImage = "https://pbs.twimg.com/media/GVMvr8wXQAAYpYo?format=jpg&name=large",
            Images = new List<string>
            {
                "https://pbs.twimg.com/media/GVMvr8wXQAAYpYo?format=jpg&name=large",
                "https://pbs.twimg.com/media/GVMvr8wXQAAYpYo?format=jpg&name=large",
                "https://pbs.twimg.com/media/GVMvr8wXQAAYpYo?format=jpg&name=large"
            }
        },
        new PlayerModel
        {
            PlayerName = "Calafiori",
            AvgScore = 6.5,
            DefaultImage = "https://pbs.twimg.com/media/GVIv8rDXUAACc4t?format=jpg&name=medium",
            Images = new List<string>
            {
                "https://pbs.twimg.com/media/GVIv8rDXUAACc4t?format=jpg&name=medium",
                "https://pbs.twimg.com/media/GVIv8rDXUAACc4t?format=jpg&name=medium",
                "https://pbs.twimg.com/media/GVIv8rDXUAACc4t?format=jpg&name=medium"
            }
        }
    };
}
