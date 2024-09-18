using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProveedoresApi.Models;
using ProveedoresApi.Repositories;

namespace ProveedoresApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProveedoresController : ControllerBase
    {
        private readonly IProveedorRepository _repository;

        public ProveedoresController(IProveedorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Proveedor>>> GetAll() =>
            await _repository.GetAllAsync();

        [HttpGet("{nit}")]
        public async Task<ActionResult<Proveedor>> GetById(string nit)
        {
            var proveedor = await _repository.GetByIdAsync(nit);
            if (proveedor == null) return NotFound();
            return proveedor;
        }

        [HttpPost]
        public async Task<ActionResult> Create(Proveedor proveedor)
        {
            await _repository.CreateAsync(proveedor);
            return CreatedAtAction(nameof(GetById), new { nit = proveedor.NIT }, proveedor);
        }

        [HttpPut("{nit}")]
        public async Task<ActionResult> Update(string nit, Proveedor proveedor)
        {
            var existingProveedor = await _repository.GetByIdAsync(nit);
            if (existingProveedor == null) return NotFound();
            await _repository.UpdateAsync(nit, proveedor);
            return NoContent();
        }

        [HttpDelete("{nit}")]
        public async Task<ActionResult> Delete(string nit)
        {
            var existingProveedor = await _repository.GetByIdAsync(nit);
            if (existingProveedor == null) return NotFound();
            await _repository.DeleteAsync(nit);
            return NoContent();
        }
        
    } }
