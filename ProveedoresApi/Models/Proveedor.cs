using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ProveedoresApi.Models
{
    public class Proveedor
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("NIT"), BsonRepresentation(BsonType.String)]

        public string? NIT { get; set; }
        [BsonElement("RazonSocial"), BsonRepresentation(BsonType.String)]

        public string? RazonSocial { get; set; }
        [BsonElement("Direccion"), BsonRepresentation(BsonType.String)]

        public string? Direccion { get; set; }
        [BsonElement("Ciudad"), BsonRepresentation(BsonType.String)]

        public string? Ciudad { get; set; }
        [BsonElement("Departamento"), BsonRepresentation(BsonType.String)]

        public string? Departamento { get; set; }
        [BsonElement("Correo"), BsonRepresentation(BsonType.String)]

        public string? Correo { get; set; }
        [BsonElement("Activo"), BsonRepresentation(BsonType.Boolean)]

        public bool Activo { get; set; }
        [BsonElement("FechaCreacion"), BsonRepresentation(BsonType.DateTime)]

        public DateTime FechaCreacion { get; set; }
        [BsonElement("NombreContacto"), BsonRepresentation(BsonType.String)]

        public string? NombreContacto { get; set; }
        [BsonElement("CorreoContacto"), BsonRepresentation(BsonType.String)]

        public string? CorreoContacto { get; set; }
    }
}