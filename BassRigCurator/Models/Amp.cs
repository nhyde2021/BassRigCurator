namespace BassRigCurator.Models
{
    public class Amp
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public VolumeLevel Volume { get; set; }


        public Amp()
        {

        }

        public Amp(string brand, string model, int price, string portable, string description, VolumeLevel volume)
        {
            Brand = brand;
            Model = model;
            Price = price;
            Description = description;
            Volume = volume;

        }

        public override string ToString()
        {
            return Brand + " " + Model;
        }
    }
}
