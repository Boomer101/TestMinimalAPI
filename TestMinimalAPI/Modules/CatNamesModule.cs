using Microsoft.OpenApi.Extensions;
using TestMinimalAPI.Models;

public static class CatsModule
{
    public static void RegisterCatsModuleEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/cats", () =>
        {
            var cats = LoadRandomCatData();

            return Results.Ok(cats);
        });
    }

    private static IEnumerable<Cat> LoadRandomCatData()
    {
        var breeds = new List<Breed>
        {
            new Breed
            {
                Name = "American Bobtail",
                WayOfLife = WayOfLife.Domestic,
                Description = "American Bobtails are a very sturdy breed, with both short- and long-haired coats"
            },

            new Breed{
                Name = "Burmese",
                WayOfLife = WayOfLife.Domestic,
                //Description = "Most modern Burmese are descendants of one female cat called Wong Mau"
            }
        };

        var cats = new List<Cat>
        {
            new Cat
            {
                Name = "Felix",
                Sex = Sex.Male,
                Breed = breeds.First()
            },

            new Cat
            {
                Name = "Sina",
                Sex = Sex.Female,
                Breed =breeds[1]
            }

        };

        return cats;
    }
}