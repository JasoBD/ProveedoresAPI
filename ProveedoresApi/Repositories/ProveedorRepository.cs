using MongoDB.Driver;
using ProveedoresApi.Data;
using ProveedoresApi.Models;

namespace ProveedoresApi.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly ProveedorContext _context;

        public ProveedorRepository(ProveedorContext context)
        {
            _context = context;
        }

        public async Task<List<Proveedor>> GetAllAsync() =>
            await _context.Proveedores.Find(proveedor => true).ToListAsync();

        public async Task<Proveedor> GetByIdAsync(string nit) =>
            await _context.Proveedores.Find<Proveedor>(prov => prov.NIT == nit).FirstOrDefaultAsync();

        public async Task CreateAsync(Proveedor proveedor) =>
            await _context.Proveedores.InsertOneAsync(proveedor);

        public async Task UpdateAsync(string nit, Proveedor proveedor) =>
            await _context.Proveedores.ReplaceOneAsync(prov => prov.NIT == nit, proveedor);

        public async Task DeleteAsync(string nit) =>
            await _context.Proveedores.DeleteOneAsync(prov => prov.NIT == nit);
    }
}
