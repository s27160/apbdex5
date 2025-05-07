using Microsoft.AspNetCore.Mvc;
using VetClinic.Models;

namespace VetClinic.Controllers;

[ApiController]
[Route("api/v1/animals/{animalId:int}/visits")]
public class VisitsController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Visit>> GetVisitsForAnimal(int animalId)
    {
        var animalExists = DataStorage.Animals.Any(a => a.Id == animalId);
        if (!animalExists) return NotFound();

        var visits = DataStorage.Visits.Where(v => v.AnimalId == animalId);
        return Ok(visits);
    }

    [HttpPost]
    public ActionResult<Visit> CreateVisit(int animalId, Visit visit)
    {
        var animalExists = DataStorage.Animals.Any(a => a.Id == animalId);
        if (!animalExists) return NotFound();

        visit.Id = DataStorage.Visits.Count != 0 ? DataStorage.Visits.Max(v => v.Id) + 1 : 1;
        visit.AnimalId = animalId;
        DataStorage.Visits.Add(visit);

        return CreatedAtAction(nameof(GetVisitsForAnimal), new { animalId = animalId }, visit);
    }
}