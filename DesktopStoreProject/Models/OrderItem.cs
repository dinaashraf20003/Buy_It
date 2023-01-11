using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DesktopStoreProject.Models
{
    internal class OrderItem : Product
    {

        private int quantity;
        [BsonElement("quantity")]
        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                if (value > 0) quantity = value;
            }
        }

        public OrderItem(int quantity, string id, string name, float price, int stock, string description, List<string> images, string brand, Category category) : base(id, name, price, stock, description, images, category, brand)
        {
            Quantity = quantity;
        }

        public void IncrementQuantity()
        {
            Quantity++;
        }

        public void DecrementQuantity() { Quantity--; }
    }
}
