

namespace Packages.Estenis.GameData_
{
    public class GameDataFloat : GameData<float>
    {
        
        public static implicit operator float(GameDataFloat d) => d.Data;
    }
}
