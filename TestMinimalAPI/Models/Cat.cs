using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestMinimalAPI.Models
{
    public enum Sex
    {
        Female,
        Male
    }

    public record Cat([Required] string Name, Sex Sex, int Age, [Required] Breed Breed);
}
