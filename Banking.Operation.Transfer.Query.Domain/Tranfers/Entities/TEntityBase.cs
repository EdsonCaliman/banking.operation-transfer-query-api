using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Banking.Operation.Transfer.Query.Domain.Tranfers.Entities
{
    public class TEntityBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}