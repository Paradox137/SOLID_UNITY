using UnityEngine;

namespace Core.OCP.Problem
{
    public class Bullet : MonoBehaviour
    {
        void OnCollisionEnter(Collision collision)
        {
            var hit = collision.gameObject;
            var enemy = hit.GetComponent<Enemy>();

            if (enemy == null)
                return;

            switch (hit.tag)
            {
                case "Shadow":
                    enemy.ApplyDamageToShadow();
                    break;
                case "Gigas":
                    enemy.ApplyDamageToGigas();
                    break;
                //! PROBLEM: added 
                case "DarkInferno":
                    enemy.ApplyDamageToDarkInferno();
                    break;
            }
        }
    }
}