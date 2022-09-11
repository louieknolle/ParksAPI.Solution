using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksAPI.Models;

namespace ParksAPI.Controllers
{
  [Produces("application/json")]
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParksAPIContext _db;

    public ParksController(ParksAPIContext db)
    {
      _db = db;
    }

    /// <summary>
    /// Parks List
    /// </summary>
    /// <remarks>
    ///
    /// Sample request:
    /// GET /api/animals
    ///     
    /// </remarks>
    /// 
    /// <returns>Parks List</returns>
    /// <response code="200">Returns Parks List</response>
    /// <response code="400">If the park is null</response> 

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string parkName, string location, string type)
    {
      var query = _db.Parks.AsQueryable();

      if (parkName != null)
      {
        query = query.Where(entry => entry.ParkName == parkName);
      }

      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }

      if (typeOfPark != null)
      {
        query = query.Where(entry => entry.TypeOfPark == typeOfPark);
      }

      return await query.ToListAsync();
    }

    [HttpGet("{search}")]
    public async Task<ActionResult<IEnumerable<Park>>> Search(string parkName, string? location, string? typeOfPark)
    {
      var query = _db.Parks.AsQueryable();

      if (parkName != null)
      {
        query = query.Where(entry => entry.ParkName == parkName);
      } 

      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }

       if (typeOfPark != null)
      {
        query = query.Where(entry => entry.TypeOfPark == typeOfPark);
      }
      
      return await query.ToListAsync();
    }

    /// <summary>
    /// Return individual park by its Id
    /// </summary>
    /// <remarks>
    ///
    /// Sample request:
    /// GET /api/parks/1
    ///     
    /// </remarks>
    /// 
    /// <returns>Return park by its Id</returns>
    /// <response code="200">Returns park</response>
    /// <response code="400">If the park is null</response> 
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
        var park = await _db.Parks.FindAsync(id);

        if (park == null)
        {
            return NotFound();
        }

        return park;
    }

    /// <summary>
    /// Creates park.
    /// </summary>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /Todo
    ///     {
    ///        "id": 1,
    ///        "name": "Park1",
    ///        "location": "Location1"
    ///     }
    ///
    /// </remarks>
    /// 
    /// <returns>A newly created Park</returns>
    /// <response code="201">Returns the newly created Park</response>
    /// <response code="400">If the Park is null</response> 

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    /// <summary>
    /// Update park 
    /// </summary>
    /// <remarks>
    ///
    /// Sample request:
    /// PUT /api/parks/1 
    ///     
    /// </remarks>
    /// 
    /// <returns>updated park in API</returns>
    /// <response code="201">park Updated Successfully</response>
    /// <response code="400">If the park is null</response> 
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesDefaultResponseType]
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Entry(park).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    /// <summary>
    /// Delete Animal 
    /// </summary>
    /// <remarks>
    ///
    /// 
    ///     
    /// </remarks>
    /// 
    /// <returns>Animal List</returns>
    /// <response code="201">Animal Deleted successfully</response>
    /// <response code="400">If the animal is null</response> 
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }
  }
}