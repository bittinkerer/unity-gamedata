using UnityEngine;

namespace Packages.Estenis.GameData_
{
    public class GameDataVector3 : GameData<Vector3>
    {

        public static implicit operator Vector3(GameDataVector3 d) => d.Data;
    }
}
