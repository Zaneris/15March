using Interview.Data;
using Interview.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Interview.Controllers;

/// <summary>
/// For all vehicle related endpoints.
/// </summary>
[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public class VehicleController : ControllerBase
{
    private readonly DataContext _context;

    public VehicleController(DataContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Get all vehicles in database.
    /// </summary>
    /// <returns>List of all vehicles.</returns>
    [HttpGet("All")]
    public async Task<IEnumerable<VehicleModel>> Get()
    {
        return await _context.VehicleModels.ToArrayAsync();
    }
}
