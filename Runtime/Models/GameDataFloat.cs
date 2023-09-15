using Assets.Scripts.StateMachine.Models;

namespace Assets.Scripts.Game.StateMachine.Models
{
    public class GameDataFloat : GameData<float>
    {
        
        public static implicit operator float(GameDataFloat d) => d.Data;
    }
}
