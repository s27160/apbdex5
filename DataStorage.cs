using VetClinic.Models;

namespace VetClinic;

public static class DataStorage
{
    public static List<Animal> Animals { get; } = [];
    public static List<Visit> Visits { get; } = [];

    static DataStorage()
    {
        Animals.Add(new Animal { Id = 1, Name = "Burek", Category = "Pies", Weight = 12.5, FurColor = "Brązowy" });
        Animals.Add(new Animal { Id = 2, Name = "Mruczek", Category = "Kot", Weight = 4.3, FurColor = "Szary" });
    }
}