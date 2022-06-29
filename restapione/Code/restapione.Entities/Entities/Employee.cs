using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace restapione.Entities.Entities
{
    [BsonIgnoreExtraElements]
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id  { get; set; }
        public int id  { get; set; }
        public string name  { get; set; }
        
    }

}
