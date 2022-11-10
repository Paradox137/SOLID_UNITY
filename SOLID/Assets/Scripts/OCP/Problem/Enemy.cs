using UnityEngine;

namespace Core.Scripts.OCP.Problem
{
    public class Enemy : MonoBehaviour
    {
        public void ApplyDamageToShadow()
        {
            Debug.Log("Shadow");
        }

        public void ApplyDamageToGigas()
        {
            Debug.Log("Gigas");
        }
        
        //  ! PROBLEM: added 
        public void ApplyDamageToDarkInferno()
        {
            Debug.Log("DarkInferno");
        }
    }
}