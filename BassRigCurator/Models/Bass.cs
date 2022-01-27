namespace BassRigCurator.Models
{
    public class Bass
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public GenreType Genre { get; set; }

        public Bass()
        {

        }

        public Bass(string brand, string model, int price, string description)
        {
            Brand = brand;
            Model = model;
            Price = price;
            Description = description;
        }

        public override string ToString()
        {
            return Brand + " " + Model;
        }
    }
}
