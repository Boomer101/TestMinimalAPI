using System.ComponentModel;

namespace TestMinimalAPI.Models
{
    public enum Sex
    {
        Female,
        Male
    }

    public class Cat
    {
        public string Name { get; set; }

        public Sex Sex { get; set; }

        public Breed Breed { get; set; }
    }
}
