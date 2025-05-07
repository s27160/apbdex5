using Swashbuckle.AspNetCore.Annotations;

namespace VetClinic.Models;

public class Animal
{
    [SwaggerSchema(ReadOnly = true)]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public double Weight { get; set; }
    public string FurColor { get; set; } = string.Empty;
}