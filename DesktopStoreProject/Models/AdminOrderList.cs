using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopStoreProject.Models
{
    internal class AdminOrderList
    {
        public static List<Order> List()
        {
            var OrderFilter = Builders<Order>.Filter.Empty;
            var order = Global.OrdersCollection.Find(OrderFilter).ToList();
            return order;
        }
    }
}
