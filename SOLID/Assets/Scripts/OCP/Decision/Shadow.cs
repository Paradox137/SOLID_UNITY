using UnityEngine;

namespace Core.OCP.Decision
{
    public class Shadow : MonoBehaviour, IEnemy
    {
        public void ApplyDamage()
        {
            Debug.Log("Shadow");
        }
    }
}