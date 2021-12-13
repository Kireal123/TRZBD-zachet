using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TRZBD_zachet.Data;
using TRZBD_zachet.Models;

namespace TRZBD_zachet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Class1Controller : ControllerBase
    {
        private readonly TRZBD_zachetContext _context;

        public Class1Controller(TRZBD_zachetContext context)
        {
            _context = context;
        }

        // GET: api/Class1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class1>>> GetClass1()
        {
            return await _context.Class1.ToListAsync();
        }

        // GET: api/Class1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Class1>> GetClass1(int id)
        {
            var class1 = await _context.Class1.FindAsync(id);

            if (class1 == null)
            {
                return NotFound();
            }

            return class1;
        }

        // PUT: api/Class1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClass1(int id, Class1 class1)
        {
            if (id != class1.Id)
            {
                return BadRequest();
            }

            _context.Entry(class1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Class1Exists(id))
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

        // POST: api/Class1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Class1>> PostClass1(Class1 class1)
        {
            _context.Class1.Add(class1);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClass1", new { id = class1.Id }, class1);
        }

        // DELETE: api/Class1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClass1(int id)
        {
            var class1 = await _context.Class1.FindAsync(id);
            if (class1 == null)
            {
                return NotFound();
            }

            _context.Class1.Remove(class1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Class1Exists(int id)
        {
            return _context.Class1.Any(e => e.Id == id);
        }
    }
}
