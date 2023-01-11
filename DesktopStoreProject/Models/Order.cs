using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace DesktopStoreProject.Models
{
    internal class Order
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("clientId")]
        public string ClientId { get; set; }

        [BsonElement("date")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime Date { get; set; }

        [BsonElement("status")]
        [BsonRepresentation(BsonType.String)]
        public OrderStatus Status { get; set; } = OrderStatus.PROCESSING;

        [BsonElement("items")]
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();


        public Order(string clientId, DateTime date, List<OrderItem> orderItems)
        {
            ClientId = clientId;
            Date = date;
            OrderItems = orderItems;
        }

        public void UpdateStatus()
        {
            if (Status == OrderStatus.DELIVERED)
            {
                throw new Exception("Order is delivered. Status cannot be updated!");
            }
            Status += 1;
            var filter = Builders<Order>.Filter.Eq(doc => doc.Id, Id);
            var update = Builders<Order>.Update.Set(doc => doc.Status, Status);
            Global.OrdersCollection.FindOneAndUpdate(filter, update);
        }
    }
}
