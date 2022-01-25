namespace BassRigCurator.Models
{
    public class Bass
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; set; }

        public Bass(string name, int price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
