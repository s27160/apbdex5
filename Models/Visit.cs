using Swashbuckle.AspNetCore.Annotations;

namespace VetClinic.Models;

public class Visit
{
    [SwaggerSchema(ReadOnly = true)]
    public int Id { get; set; }
    [SwaggerSchema(ReadOnly = true)]
    public int AnimalId { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; } = string.Empty;
    public double Price { get; set; }
}