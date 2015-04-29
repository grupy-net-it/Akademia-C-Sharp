namespace wyklad2.types
{
    internal class Wizard : Player
    {
        public Wizard()
        {
            this.health = 80;
            this.baseArmor = 10;
            this.mana = 100;
            this.baseDamage = 30;
        }

        protected int mana;
    }
}
