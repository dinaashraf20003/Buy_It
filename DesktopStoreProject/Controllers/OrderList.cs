using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopStoreProject.Controllers
{
    internal class OrderList
    {
        public static List<Order> List(string email)
        {
            var filter = Builders<User>.Filter.Eq(doc => doc.Email, email);
            var user = Global.UsersCollection.Find(filter).FirstOrDefault();
            var OrderFilter = Builders<Order>.Filter.Eq(doc => doc.ClientId, user.Id);
            var order = Global.OrdersCollection.Find(OrderFilter).ToList();
            return order;
        }
    }
}
