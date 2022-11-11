namespace Core.DIP.Problem
{
    public class Player
    {
        public void Attack()
        {
            //! PROBLEM А если кол-во типов аттаки увеличиться?
            var attack = new SlashAttack();
            attack.ApplyDamage();
        }
    }
}