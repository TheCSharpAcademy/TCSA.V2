using System.Text.Json;

namespace TCSA.V2.Services;

public interface ICountriesService
{
    Task<List<string>> GetCountries ();
}

public class CountriesService : ICountriesService
{
    static HttpClient client = new HttpClient();

    public async Task<List<string>> GetCountries ()
    {
        var result = new List<string>();

        try
        {
            await using Stream stream =
        await client.GetStreamAsync("https://restcountries.com/v3.1/all");
            var rootObject =
            await JsonSerializer.DeserializeAsync<Country[]>(stream);

            foreach (var c in rootObject)
            {
                result.Add(c.name.common);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return result;
    }
}

public record class Country (Name name);

public record class Name (string common);



