namespace TCSA.V2.Helpers;

public static class RoadmapHelper
{
    public static readonly int[] GreenRequirements = { 5, 6, 7, 8, 53, 75 };
    public static readonly int[] OliveGreenRequirements = { 11, 12, 13 };
    public static readonly int[] YellowRequirements = { 14, 15, 16, 17 };
    public static readonly int[] OrangeRequirements = { 18, 19, 20, 21 };
    public static readonly int[] RedRequirements = { 22, 23 };
    public static readonly int[] GreyAndBlackRequirements = { 139 };
    public static readonly int[] AspNetRequirements = { 24, 25, 26, 27 };
    public static readonly int[] AngularRequirements = { 31, 32, 33, 34 };
    public static readonly int[] ReactRequirements = { 35, 36, 37, 38 };
    public static readonly int[] BlazorRequirements = { 39, 40, 41, 42 };
    public static readonly int[] MauiRequirements = { 43, 44, 45, 46 };
    public static readonly int[] AuthRequirements = { 28, 72, 74 };
    public static readonly int[] SqlRequirements = { 76, 77, 78 };
    public static readonly int[] AzureRequirements = { 47, 48, 49, 50 };
    public static readonly int[][] FullStackAreas = { AspNetRequirements, AngularRequirements, ReactRequirements, BlazorRequirements, MauiRequirements };
    public static readonly int[][] AspNetAreas = { AspNetRequirements, BlazorRequirements, MauiRequirements };

    public static readonly List<string> GreenBeltReqs = new()
    {
        "Read the 5 articles below",
        "Complete Freecodecamp C# Certification",
        "Complete Math Game project"
    };

    public static readonly List<string> OliveGreenBeltReqs = new()
    {
        "Complete Calculator project",
        "Complete Habit Logger project",
        "Complete Coding Tracker project"
    };

    public static readonly List<string> YellowBeltReqs = new()
    {
        "Complete Flashcards project",
        "Complete Drinks Info project",
        "Complete Phone Book project",
        "Complete Shifts Logger project"
    };
    public static readonly List<string> OrangeBeltReqs = new()
    {
        "Complete Exercise Tracker project",
        "Complete Sports Results notifier project",
        "Complete Excel Reader project",
        "Complete Unit Testing project"
    };
    public static readonly List<string> RedBeltReqs = new()
    {
        "Complete Portfolio project",
        "Complete Resume project",
        "Complete 2 Code Reviews",
        "Complete 1 Community Project Issue"
    };
    public static readonly List<string> PurpleBeltReqs = new()
    {
        "Complete 1 Full-stack area",
        "Complete 2 Code Reviews",
        "Complete 1 Community Project Issue"
    };
    public static readonly List<string> BrownBeltReqs = new()
    {
        "Complete Auth Area",
        "Complete 3 Code Reviews",
        "Complete 2 Community Project Issues"
    };
    public static readonly List<string> GreyBeltReqs = new()
    {
        "Complete SQL Challenges",
        "Complete 5 Code Reviews",
        "Complete 3 Community Project Issues",
        "Submit a PR with Readme and Systems Design For Flagship Project"
    };
    public static readonly List<string> BlueBeltReqs = new()
    {
        "Complete Azure Area",
        "Complete 5 Code Reviews",
        "Complete 3 Community Project Issues"
    };
    public static readonly List<string> BlackBeltReqs = new()
    {
        "Complete at least 2 full-stack areas. One of them has to be MVC, Blazor or Maui",
        "Complete 8 Code Reviews",
        "Complete 5 Community Project Issues",
        "Complete Flagship Project"
    };
}
