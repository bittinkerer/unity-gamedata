using UnityEngine;

namespace Assets.Scripts.StateMachine.Models
{
    public class GameDataBoxCollider : GameData<BoxCollider>
    {

        public static implicit operator BoxCollider(GameDataBoxCollider d) => d.Data;
    }
}
