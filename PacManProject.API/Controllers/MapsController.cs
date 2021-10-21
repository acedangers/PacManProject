using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PacManProject.BusinessLogic.DTO;
using PacManProject.DataAccess.DAL.Context;
using PacManProject.DataAccess.DAL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacManProject.API.Controllers
{
    [Route("api/Maps")]
    [ApiController]
    public class MapsController : ControllerBase
    {
        private readonly AppDBContext _context;

        private static MapDTO MapToDTO(Map map) => new MapDTO
        {
            Id = map.Id,
            Width = map.Width,
            Height = map.Height
        };

        public MapsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Maps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MapDTO>>> GetMaps()
        {
            return await _context.Maps.Select(x => MapToDTO(x)).ToListAsync();
        }

        // GET: api/Maps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MapDTO>> GetMap(int id)
        {
            var map = await _context.Maps.FindAsync(id);

            if (map == null)
            {
                return NotFound();
            }

            return MapToDTO(map);
        }

        // PUT: api/Maps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMap(int id, MapDTO mapDTO)
        {
            if (id != mapDTO.Id)
            {
                return BadRequest();
            }

            //_context.Entry(map).State = EntityState.Modified;
            var map = await _context.Maps.FindAsync(id);
            if (map == null)
            {
                return NotFound();
            }

            map.Width = mapDTO.Width;
            map.Height = mapDTO.Height;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!MapExists(id))
            {
                if (!MapExists(id))
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

        // POST: api/Maps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MapDTO>> PostMap(MapDTO mapDTO)
        {
            var map = new Map
            {
                Width = mapDTO.Width,
                Height = mapDTO.Height
            };

            _context.Maps.Add(map);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetMap", new { id = map.Id }, map);
            //return CreatedAtAction(nameof(GetMap), new { id = map.Id }, map);

            return CreatedAtAction(nameof(GetMap), new { id = map.Id }, MapToDTO(map));
        }

        // DELETE: api/Maps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMap(int id)
        {
            var map = await _context.Maps.FindAsync(id);
            if (map == null)
            {
                return NotFound();
            }

            _context.Maps.Remove(map);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MapExists(int id)
        {
            return _context.Maps.Any(e => e.Id == id);
        }
    }
}
