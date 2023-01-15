using System.ComponentModel.DataAnnotations;

namespace TestMinimalAPI.Models
{
    public enum WayOfLife
    {
        Domestic,
        Feral
    }

    public record Breed([Required] string Name, WayOfLife WayOfLife, string Description);
    
}
