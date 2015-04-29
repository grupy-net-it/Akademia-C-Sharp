namespace wyklad2
{
    internal class Enemy
    {
        protected int health;
        protected int armor;
        protected int damage;

        public Enemy()
        {
            this.health = 100;
            this.armor = 10;
            this.damage = 40;
        }

        public void Attack(Player player)
        {
            player.Defend(damage);
            //To potem - przy events
            //player.Attack(this);
        }

        public void Defend(int damageOutput)
        {
            if((damageOutput - armor) > 0)
            {
                this.health -= (damageOutput - armor);
            }
        }
    }
}
