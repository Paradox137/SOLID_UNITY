using UnityEngine;

namespace Core.SRP.Decision
{
    public class PlayerMove : MonoBehaviour
    {
        private float speed;
        
        private void Move(Vector3 direction)
        {
            this.transform.position += direction * Time.deltaTime * this.speed;
            this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
        }
        
        private void OnEnable()
        {
            PlayerInput.onPlayerInput += Move;
        }

        private void OnDisable()
        {
            PlayerInput.onPlayerInput -= Move;
        }
    }
}