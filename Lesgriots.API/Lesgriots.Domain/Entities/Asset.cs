using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Lesgriots.Domain.Entities
{
    public class Asset
    {
        [BsonId]  // Indique que c'est l'identifiant MongoDB
        [BsonRepresentation(BsonType.ObjectId)]  // Convertit ObjectId en string
        [BsonElement("_id")]  // Indique que MongoDB stocke l'ID sous "_id"
        public string Id { get; set; } = null!;

        [BsonElement("Titre")]
        public string Titre { get; set; } = null!;

        [BsonElement("Description")]
        public string Description { get; set; } = null!;

        [BsonElement("Images")]
        public List<string> Images { get; set; } = new();

        [BsonElement("URL")]
        public string URL { get; set; } = null!;
    }
}
