using ProveedoresApi.Models;

namespace ProveedoresApi.Repositories
{
    public interface IProveedorRepository
    {
        Task<List<Proveedor>> GetAllAsync();
        Task<Proveedor> GetByIdAsync(string nit);
        Task CreateAsync(Proveedor proveedor);
        Task UpdateAsync(string nit, Proveedor proveedor);
        Task DeleteAsync(string nit); 
    }
}
