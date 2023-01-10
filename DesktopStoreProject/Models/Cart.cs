using MongoDB.Driver;
using System; 

namespace DesktopStoreProject
{
    internal class Cart
    {
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public int TotalQuantity { get; private set; }

        public float TotalCost { get; private set; }

        public void AddItem(string id, int quantity)
        {
            var filter = Builders<Product>.Filter.Eq(doc => doc.Id, id);
            var item = Global.ProductsCollection.Find(filter).FirstOrDefault();
            Product AddedItem = new Product(item.Id, item.Name, item.Price, item.Stock, item.Description,
                item.Images, item.Category, item.Brand);
            OrderItem Order = AddedItem.CreateOrderItem(quantity);
            TotalCost += Order.Price * Order.Quantity;
            TotalQuantity += Order.Quantity;
            Items.Add(Order);
        }
        public void RemoveItem(string id, int quantity) {
            var filter = Builders<Product>.Filter.Eq(doc => doc.Id, id);
            var item = Global.ProductsCollection.Find(filter).FirstOrDefault();
            Product AddedItem = new Product(item.Id, item.Name, item.Price, item.Stock, item.Description,
                item.Images, item.Category, item.Brand);
            OrderItem Order = AddedItem.CreateOrderItem(quantity);
            TotalCost += Order.Price * Order.Quantity;
            TotalQuantity += Order.Quantity;
            Items.Remove(Order); 
        }

        public void ResetCart()
        {
            TotalQuantity = 0;
            TotalCost = 0;
            Items.Clear();
        }
    }
}
