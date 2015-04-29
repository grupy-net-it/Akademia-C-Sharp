namespace wyklad2
{
    internal class Weapon : Item
    {
        public Weapon (int damage, int weight)
        {
            this.Name = "Broń";
            this.Weight = weight;
            this.Damage = damage;
        }

        public int Damage { get; private set; }
    }
}
