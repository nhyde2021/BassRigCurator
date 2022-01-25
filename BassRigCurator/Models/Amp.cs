namespace BassRigCurator.Models
{
    public class Amp
    {
        public string Name { get; set; }
        public string Volume { get; set; }
        public int Price { get; set; }
        public string Portable { get; set; }
        public string Description { get; set; }

        public Amp(string name, string volume, int price, string portable, string description )
        {
            Name = name;
            Volume = volume;
            Price = price;
            Portable = portable;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
