using System; 

namespace DesktopStoreProject
{
    internal class Cart
    {
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public int TotalQuantity { get; private set; }

        public float TotalCost { get; private set; }

        public void AddItem(OrderItem item)
        {
            TotalCost += item.Price * item.Quantity;
            TotalQuantity += item.Quantity;
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item) {
            TotalCost -= item.Price * item.Quantity;
            TotalQuantity -= item.Quantity;
            Items.Remove(item); 
        }
    }
}
