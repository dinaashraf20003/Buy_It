using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace DesktopStoreProject
{
    internal class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("country")]
        public string Country { get; set; }

        public List<String> OrdersMade { get; set; } = new List<String>(); // list of the ids of the orders this user made

        public User( string name, string address, string email, string phone, string country)
        {
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
            Country = country;
        }
    }
}
