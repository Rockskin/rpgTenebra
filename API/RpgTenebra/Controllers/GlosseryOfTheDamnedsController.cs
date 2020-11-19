using Microsoft.AspNetCore.Mvc;
using RpgTenebra.Models.VampireM5;
using RpgTenebra.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgTenebra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GlosseryOfTheDamnedsController : ControllerBase
    {
        private readonly IGlosseryOfTheDamnedRepository _glosseryOfTheDamnedRepository;

        public GlosseryOfTheDamnedsController(IGlosseryOfTheDamnedRepository productRepository)
        {
            _glosseryOfTheDamnedRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<GlosseryOfTheDamned>> GellAll()
        {
            var products = await _glosseryOfTheDamnedRepository.GetAllGlosseryOfTheDamneds();
            return Ok(products);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<GlosseryOfTheDamned>> GetById(int id)
        {
            var product = await _glosseryOfTheDamnedRepository.GetById(id);
            return Ok(product);
        }
        [HttpPost]
        public async Task<ActionResult> AddProduct(GlosseryOfTheDamned entity)
        {
            await _glosseryOfTheDamnedRepository.AddGlosseryOfTheDamned(entity);
            return Ok(entity);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<GlosseryOfTheDamned>> Update(GlosseryOfTheDamned entity, int id)
        {
            await _glosseryOfTheDamnedRepository.UpdateGlosseryOfTheDamned(entity, id);
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _glosseryOfTheDamnedRepository.RemoveGlosseryOfTheDamned(id);
            return Ok();
        }
    }

}
