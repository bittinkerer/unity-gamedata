using UnityEngine;

namespace Packages.Estenis.GameData.RunTime.Models
{
    public class GameDataBoxCollider : GameData<BoxCollider>
    {

        public static implicit operator BoxCollider(GameDataBoxCollider d) => d.Data;
    }
}
