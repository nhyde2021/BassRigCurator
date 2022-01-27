namespace BassRigCurator.Models
{
    public class Bass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public GenreType Genre { get; set; }

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
