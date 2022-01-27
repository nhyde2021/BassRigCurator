namespace BassRigCurator.Models
{
    public class Amp
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Volume { get; set; }
        public int Price { get; set; }
        public string Portable { get; set; }
        public string Description { get; set; }

        public Amp()
        {

        }

        public Amp(string brand, string model, string volume, int price, string portable, string description )
        {
            Brand = brand;
            Model = model;
            Volume = volume;
            Price = price;
            Portable = portable;
            Description = description;
        }

        public override string ToString()
        {
            return Brand + " " + Model;
        }
    }
}
