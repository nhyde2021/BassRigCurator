namespace BassRigCurator.Models
{
    public class Amp
    {
        public string Name { get; set; }
        public int Volume { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public Amp(string name, int volume, int price, string description)
        {
            Name = name;
            Volume = volume;
            Price = price;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
