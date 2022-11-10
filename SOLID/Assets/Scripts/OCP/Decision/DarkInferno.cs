using UnityEngine;

namespace Core.OCP.Decision
{
    public class DarkInferno : MonoBehaviour, IEnemy
    {
        public void ApplyDamage()
        {
            Debug.Log("DarkInferno");
        }
    }
}