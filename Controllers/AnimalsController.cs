using Microsoft.AspNetCore.Mvc;
using VetClinic.Models;

namespace VetClinic.Controllers;

[ApiController]
[Route("api/v1/animals")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> GetAll()
    {
        return Ok(DataStorage.Animals);
    }

    [HttpGet("{name}")]
    public ActionResult<IEnumerable<Animal>> GetAllByName(string name)
    {
        var animals = DataStorage.Animals.AsEnumerable();
        if (!string.IsNullOrWhiteSpace(name))
        {
            animals = animals.Where(a => a.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }

        return Ok(animals);
    }

    [HttpGet("{id:int}")]
    public ActionResult<Animal> GetById(int id)
    {
        var animal = DataStorage.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null) return NotFound();
        return Ok(animal);
    }

    [HttpPost]
    public ActionResult<Animal> Create(Animal animal)
    {
        animal.Id = DataStorage.Animals.Count != 0 ? DataStorage.Animals.Max(a => a.Id) + 1 : 1;
        DataStorage.Animals.Add(animal);
        return CreatedAtAction(nameof(GetById), new { id = animal.Id }, animal);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, Animal updatedAnimal)
    {
        var animal = DataStorage.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null) return NotFound();

        animal.Name = updatedAnimal.Name;
        animal.Category = updatedAnimal.Category;
        animal.Weight = updatedAnimal.Weight;
        animal.FurColor = updatedAnimal.FurColor;

        return Ok(animal);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var animal = DataStorage.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null) return NotFound();

        DataStorage.Animals.Remove(animal);
        DataStorage.Visits.RemoveAll(v => v.AnimalId == id);

        return NoContent();
    }
}