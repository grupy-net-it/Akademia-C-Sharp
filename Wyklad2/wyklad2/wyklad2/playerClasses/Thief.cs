namespace wyklad2.PlayerClasses
{
    internal class Thief : Player
    {
        public Thief()
        {
            this.health = 90;
            this.baseArmor = 15;
            this.energy = 100;
            this.baseDamage = 25;
        }

        protected int energy;
    }
}
