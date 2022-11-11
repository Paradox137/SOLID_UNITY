using UnityEngine;

namespace Core.DIP.Decision
{
    public class TestMB : MonoBehaviour
    {
        void Start()
        {
            var attack = new SlashAttack();
            var player = new Player(attack);
            player.Attack();
        }
    }
}