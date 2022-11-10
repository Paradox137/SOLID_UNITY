using UnityEngine;

namespace Core.SRP.Problem
{
    public sealed class Player : MonoBehaviour
    {
        private float speed;

        private void Update()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.Move(Vector3.up);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                this.Move(Vector3.down);
            }
        }

        private void Move(Vector3 direction)
        {
            this.transform.position += direction * Time.deltaTime * this.speed;
            this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
        }
    }
}