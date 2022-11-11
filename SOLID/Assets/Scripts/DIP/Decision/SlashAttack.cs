using UnityEngine;

namespace Core.DIP.Decision
{
    public class SlashAttack : IAttack
    {
        public void ApplyDamage()
        {
            Debug.Log("斬撃攻撃でダメージを与える");
        }
    }
}