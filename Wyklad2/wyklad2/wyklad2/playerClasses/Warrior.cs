namespace wyklad2.PlayerClasses
{
    internal class Warrior : Player
    {
        public Warrior()
        {
            this.health = 100;
            this.baseArmor = 20;
            this.rage = 0;
            this.baseDamage = 20;
        }

        protected int rage;
    }
}
