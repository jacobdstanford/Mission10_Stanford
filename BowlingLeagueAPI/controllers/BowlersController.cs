using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BowlingLeagueAPI.Data;
using BowlingLeagueAPI.Models;

namespace BowlingLeagueAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BowlersController : ControllerBase
    {
        private readonly BowlingLeagueContext _context;

        public BowlersController(BowlingLeagueContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetBowlers()
        {
            var bowlers = await (from b in _context.Bowlers
                                 join t in _context.Teams
                                     on b.TeamID equals t.TeamID
                                 // Filter for only Marlins & Sharks
                                 where t.TeamName == "Marlins" || t.TeamName == "Sharks"
                                 // Return the fields you need
                                 select new
                                 {
                                     FirstName = b.BowlerFirstName,
                                     MiddleInit = b.BowlerMiddleInit,
                                     LastName = b.BowlerLastName,
                                     TeamName = t.TeamName,
                                     Address = b.BowlerAddress,
                                     City = b.BowlerCity,
                                     State = b.BowlerState,
                                     Zip = b.BowlerZip,
                                     PhoneNumber = b.BowlerPhoneNumber
                                 }).ToListAsync();

            return Ok(bowlers);
        }
    }
}
