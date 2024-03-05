namespace TCSA.V2.Helpers;

public static class FlagHelper
{
    public static string GetFlag(string country)
    {
        var countriesWithFlags = new List<string> { "Algeria", "Argentina", "Australia", "Austria", "Azerbaijan", "Brazil", "Bangladesh", "Belgium", "Belarus", "Bosnia and Herzegovina", "Bulgaria", "Canada", "China", "Colombia", "Costa Rica", "Croatia", "Cyprus", "Czechia", "Denmark", "Dominican Republic", "Ecuador","Egypt", "Estonia", "Finland", "France", "Gambia", "Georgia", "Germany","Ghana", "Greece", "Guatemala", "Honduras", "Hungary","India", "Indonesia", "Ireland", "Israel", "Italy","Jamaica","Japan",  "Kazakhstan", "Kenya", "Kuwait", "Latvia", "Lebanon", "Liberia", "Lithuania", "Luxembourg", "Malaysia", "Mexico", "Mongolia", "Montenegro", "Morocco","Myanmar", "Nepal", "Netherlands", "New Zealand", "Nigeria", "Norway","North Macedonia", "Oman", "Panama", "Pakistan", "Peru", "Philippines", "Poland", "Portugal", "Romania", "Russia", "Saudi Arabia", "Serbia", "Singapore", "Slovakia", "Slovenia", "South Africa", "South Korea", "Spain", "Sweden","Switzerland", "Tokelau", "Turkey","Trinidad and Tobago", "Ukraine", "United Kingdom", "Uruguay", "United States", "Venezuela", "Thailand", "Turkmenistan", "United Arab Emirates","Vietnam", "Zimbabwe" };


        if (string.IsNullOrEmpty(country) || !countriesWithFlags.Contains(country))
        {
            return $"img/flags/earth.png";
        }

        var imgName = country.ToLower();

        if (country == "Bosnia and Herzegovina")
        {
            imgName = "bosnia";
        }

        if (country == "United Kingdom")
        {
            imgName = "great-britain";
        }

        if (country == "United States")
        {
            imgName = "usa";
        }

        if (country == "Costa Rica")
        {
            imgName = "cr";
        }

        if (country == "New Zealand")
        {
            imgName = "nz";
        }

        if (country == "Dominican Republic")
        {
            imgName = "dr";
        }

        if (country == "South Africa")
        {
            imgName = "south-africa";
        }

        if (country == "South Korea")
        {
            imgName = "south-korea";
        }

        if (country == "Saudi Arabia")
        {
            imgName = "saudi-arabia";
        }

        if (country == "Trinidad and Tobago")
        {
            imgName = "trinidad";
        }

        if (country == "United Arab Emirates")
        {
            imgName = "uae";
        }

        if (country == "North Macedonia")
        {
            imgName = "northmacedonia";
        }


        return $"img/flags/{imgName}.png";
    }
}
