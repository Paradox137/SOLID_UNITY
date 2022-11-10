using Core.OCP.Decision;
using UnityEngine;

namespace Core.Scripts.OCP.Decision
{
    public class Shadow : MonoBehaviour, IEnemy
    {
        public void ApplyDamage()
        {
            Debug.Log("Shadow");
        }
    }
}