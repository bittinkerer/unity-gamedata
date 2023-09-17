using UnityEngine;

namespace Packages.Estenis.GameData_
{
    public class GameDataBoxCollider : GameData<BoxCollider>
    {

        public static implicit operator BoxCollider(GameDataBoxCollider d) => d.Data;
    }
}
