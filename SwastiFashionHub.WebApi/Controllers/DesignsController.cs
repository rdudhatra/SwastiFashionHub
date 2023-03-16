﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SwastiFashionHub.Core.Services;
using SwastiFashionHub.Core.Services.Interface;
using SwastiFashionHub.Core.Wrapper;
using SwastiFashionHub.Data.Context;
using SwastiFashionHub.Data.Models;

namespace SwastiFashionHub.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignsController : ControllerBase
    {
        private readonly IDesignService _designService;

        public DesignsController(IDesignService designService)
        {
            _designService = designService;
        }

        // GET: api/Designs
        [HttpGet]
        public async Task<IActionResult> GetDesigns()
        {
            var result = await _designService.GetAllDesignAsync();
            return Ok(result);
        }

        // GET: api/Designs/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetDesign(int id)
        {
            var result = await _designService.GetDesignAsync(id);
            return Ok(result);
        }

        //// PUT: api/Designs/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutDesign(int id, Design design)
        //{
        //    if (id != design.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(design).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!DesignExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return await Result<int>.FailAsync("Failed");
        //    }

        //    return await Result<Guid>.SuccessAsync(updateCompanyByAdminCommand.Id, "Company saved successfully");
        //    return Ok(Result)
        //}

        //// POST: api/Designs
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Design>> PostDesign(Design design)
        //{
        //    if (_context.Designs == null)
        //    {
        //        return Problem("Entity set 'SwastiFashionHubLlpContext.Designs'  is null.");
        //    }
        //    _context.Designs.Add(design);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetDesign", new { id = design.Id }, design);
        //}

        //// DELETE: api/Designs/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteDesign(int id)
        //{
        //    if (_context.Designs == null)
        //    {
        //        return NotFound();
        //    }
        //    var design = await _context.Designs.FindAsync(id);
        //    if (design == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Designs.Remove(design);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool DesignExists(int id)
        //{
        //    return (_context.Designs?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
