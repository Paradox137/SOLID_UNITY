namespace Core.DIP.Decision
{
    public class Player
    {
        //+ Зависимость от абстракции а не от конкретной реализации 
        IAttack _attack;
        public Player(IAttack attack)
        {
            _attack = attack;
        }

        public void Attack()
        {
            _attack.ApplyDamage();
        }
    }
}