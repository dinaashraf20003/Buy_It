using DesktopStoreProject.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopStoreProject.Controllers
{
    internal class Purchase
    {
        public static float Receipt()
        {
            return Global.cart.TotalCost;
        }
        public static void PurchaseOrder(string email)
        {
            var filter = Builders<User>.Filter.Eq(doc => doc.Email, email);
            var user = Global.UsersCollection.Find(filter).FirstOrDefault();
            Order order = new Order(user.Id, DateTime.Now, Global.cart.Items);
            Global.OrdersCollection.InsertOne(order);
            foreach (var item in Global.cart.Items)
            {
                var Productfilter = Builders<Product>.Filter.Eq(doc => doc.Id, item.Id);
                var product = Global.ProductsCollection.Find(Productfilter).FirstOrDefault();
                var stockUpdate = Builders<Product>.Update.Set(doc => doc.Stock, product.Stock - item.Quantity);
                Global.ProductsCollection.UpdateOne(Productfilter, stockUpdate);
            }
            Global.cart.ResetCart();
        }
    }
}
