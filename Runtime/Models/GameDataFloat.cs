

namespace Packages.Estenis.GameData.RunTime.Models
{
    public class GameDataFloat : GameData<float>
    {
        
        public static implicit operator float(GameDataFloat d) => d.Data;
    }
}
