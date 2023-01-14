namespace TestMinimalAPI.Models
{
    public enum WayOfLife
    {
        Domestic,
        Feral
    }

    public class Breed
    {
        public string Name { get; set; }

        public WayOfLife WayOfLife {get; set;}

        public string Description { get; set; } = $"Description of {nameof(Name)} ";
    }
}
