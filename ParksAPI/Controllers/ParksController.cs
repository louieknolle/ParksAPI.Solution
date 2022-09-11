using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using ParksAPI.Wrappers;
using ParksAPI.Filter;
using ParksAPI.Helpers;
using ParksAPI.Services;


namespace ParksAPI.Controllers
{
  [Produces("application/json")]
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ILogger<ParksController> _logger;
    private readonly ParksAPIContext _db;
    private readonly IUriService uriService;

    public ParksController(ILogger<ParksController> logger, ParksAPIContext db, IUriService uriService)
    {
      _logger = logger;
      _db = db;
      this.uriService = uriService;
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get([FromQuery] PaginationFilter filter, string parkName, string location, string typeOfPark)
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

      var route = Request.Path.Value;
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
      var pagedData = await query
        .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
        .Take(validFilter.PageSize)
        .ToListAsync();
      var totalRecords = await query.CountAsync();
      var pagedReponse = PaginationHelper.CreatePagedReponse<Park>(pagedData, validFilter, totalRecords, uriService, route);
      return Ok(pagedReponse);

      // return await query.ToListAsync();
    }

    [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<Park>>> Search(string parkName, string? location, string? typeOfPark)
    {
      var query = _db.Parks.AsQueryable();

      if (parkName != null)
      {
        query = query.Where(entry => entry.ParkName.Contains(parkName));
      } 

      if (location != null)
      {
        query = query.Where(entry => entry.Location.Contains(location));
      }

       if (typeOfPark != null)
      {
        query = query.Where(entry => entry.TypeOfPark == typeOfPark);
      }

      var route = Request.Path.Value;
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
      var pagedData = await query
        .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
        .Take(validFilter.PageSize)
        .ToListAsync();
      var totalRecords = await query.CountAsync();
      var pagedReponse = PaginationHelper.CreatePagedReponse<Park>(pagedData, validFilter, totalRecords, uriService, route);
      return Ok(pagedReponse);
      
      // return await query.ToListAsync();
    }

    [HttpGet("random")]
    public async Task<ActionResult<Park>> Random()
    {
      using(HttpClient client = new HttpClient())
      {
        var result = await client.GetAsync("https://localhost:5001/api/parks");  
        if (result.IsSuccessStatusCode)  
        {
            var parkListString = await result.Content.ReadAsStringAsync();     
            var parkList = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Park>>(parkListString);     
            return parkList.ElementAt(new Random().Next(0, parkList.Count() - 1));  
        }
        else
        {
            return NotFound(); 
        }
      }
    }

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

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

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