using Core.Scripts.OCP.Decision;
using UnityEngine;

namespace Core.OCP.Decision
{
    public class Gigas : MonoBehaviour, IEnemy
    {
        public void ApplyDamage()
        {
            Debug.Log("Gigas");
        }
    }
}