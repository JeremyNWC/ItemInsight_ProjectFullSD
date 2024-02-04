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
    public class ListingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ListingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Listings
        [HttpGet]

        public async Task<IActionResult> GetListings()
        {
            //Refactored
            //return await _context.Listings.ToListAsync();
            var listings = await _unitOfWork.Listings.GetAll();
            return Ok(listings);
        }

        // GET: api/Listings/5
        [HttpGet("{id}")]

        public async Task<IActionResult> GetListing(int id)
        {
            var listing = await _unitOfWork.Listings.Get(q => q.Id == id);

            if (listing == null)
            {
                return NotFound();
            }

            return Ok(listing);
        }

        // PUT: api/Listings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListing(int id, Listing listing)
        {
            if (id != listing.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Listings.Update(listing);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ListingExists(id))
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

        // POST: api/Listings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Listing>> PostListing(Listing listing)
        {

            await _unitOfWork.Listings.Insert(listing);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetListing", new { id = listing.Id }, listing);
        }

        // DELETE: api/Listings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteListing(int id)
        {
            var listing = await _unitOfWork.Listings.Get(q => q.Id == id);
            if (listing == null)
            {
                return NotFound();
            }

            await _unitOfWork.Listings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ListingExists(int id)
        {
            var listing = await _unitOfWork.Listings.Get(q => q.Id == id);
            return listing != null;
        }
    }
}
