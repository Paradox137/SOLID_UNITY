using System;
using UnityEngine;

namespace Core.Core.SRP.Decision
{
    public class PlayerInput : MonoBehaviour
    {
        public static event Action<Vector3> onPlayerInput;
        
        private void Update()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                onPlayerInput?.Invoke(Vector3.up);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                onPlayerInput?.Invoke(Vector3.down);
            }
        }
    }
}