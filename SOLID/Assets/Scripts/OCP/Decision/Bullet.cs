using UnityEngine;

namespace Core.OCP.Decision 
{ 
    public class Bullet : MonoBehaviour
    {
        public void OnCollisionEnter(Collision collision)
        {
            var hit = collision.gameObject;
            var enemy = hit.GetComponent<IEnemy>();

            if (enemy == null)
                return;

            enemy.ApplyDamage();
        }
    }
}