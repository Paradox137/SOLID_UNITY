using Core.OCP.Decision;
using UnityEngine;

namespace Core.Scripts.OCP.Decision
{
    public class DarkInferno : MonoBehaviour, IEnemy
    {
        public void ApplyDamage()
        {
            Debug.Log("DarkInferno");
        }
    }
}