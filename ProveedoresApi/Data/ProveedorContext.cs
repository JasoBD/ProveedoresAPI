using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using ProveedoresApi.Models;

namespace ProveedoresApi.Data
{

    public class ProveedorContext
    {
        private readonly IMongoDatabase _database;

        public ProveedorContext(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("MongoDb"));
            _database = client.GetDatabase("ProveedoresDb");
        }

        public IMongoCollection<Proveedor> Proveedores => _database.GetCollection<Proveedor>("Proveedores");
    }
}

