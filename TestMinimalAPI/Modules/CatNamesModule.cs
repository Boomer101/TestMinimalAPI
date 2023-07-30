using System.Diagnostics;
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

        endpoints.MapPost("/cats", (Cat cat) =>
        {
            Debug.WriteLine($"POST received: {cat}");

            // TODO: Persist data
            return Results.Ok(cat);

        }).AddFluentValidationFilter(); 
    }

    private static IEnumerable<Cat> LoadRandomCatData()
    {
        var breeds = new List<Breed>
        {
            new Breed("American Bobtail", WayOfLife.Domestic, "American Bobtails are a very sturdy breed, with both short- and long-haired coats"),
            new Breed("Burmese", WayOfLife.Domestic, "Most modern Burmese are descendants of one female cat called Wong Mau"), 
            new Breed("European Shorthair", WayOfLife.Domestic, "Our neighbour fluffy cat :)")
        };

        var cats = new List<Cat>
        {
            new Cat("Felix", Sex.Male, 9, breeds.First()),
            new Cat("Sina",  Sex.Female, 5, breeds[1]),
            new Cat("Mops",  Sex.Female, 8, breeds[2]),
            new Cat("Felix", Sex.Male, 9, breeds[2]),

        };

        return cats;
    }
}