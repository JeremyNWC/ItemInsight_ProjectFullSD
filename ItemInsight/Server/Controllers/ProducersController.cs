using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ItemInsight.Server.Data;
using ItemInsight.Shared.Domain;
using ItemInsight.Server.IRepository;

namespace ItemInsight.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProducersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Producers
        [HttpGet]

        public async Task<IActionResult> GetProducers()
        {
            //Refactored
            //return await _context.Producers.ToListAsync();
            var producers = await _unitOfWork.Producers.GetAll();
            return Ok(producers);
        }

        // GET: api/Producers/5
        [HttpGet("{id}")]

        public async Task<IActionResult> GetProducer(int id)
        {
            var producer = await _unitOfWork.Producers.Get(q => q.Id == id);

            if (producer == null)
            {
                return NotFound();
            }

            return Ok(producer);
        }

        // PUT: api/Producers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducer(int id, Producer producer)
        {
            if (id != producer.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Producers.Update(producer);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ProducerExists(id))
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

        // POST: api/Producers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Producer>> PostProducer(Producer producer)
        {

            await _unitOfWork.Producers.Insert(producer);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetProducer", new { id = producer.Id }, producer);
        }

        // DELETE: api/Producers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducer(int id)
        {
            var producer = await _unitOfWork.Producers.Get(q => q.Id == id);
            if (producer == null)
            {
                return NotFound();
            }

            await _unitOfWork.Producers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ProducerExists(int id)
        {
            var producer = await _unitOfWork.Producers.Get(q => q.Id == id);
            return producer != null;
        }
    }
}
