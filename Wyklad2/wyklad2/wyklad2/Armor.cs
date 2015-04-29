namespace wyklad2
{
    internal class Armor : Item
    {
        public Armor(int protection, int weight)
        {
            this.Name = "Pancerz";
            this.Weight = weight;
            this.Protection = protection;
        }

        public int Protection { get; private set; }
    }
}
