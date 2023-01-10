using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopStoreProject.Models
{
    internal class Fetch
    {
        public static List<Product> FetchItems()
        {
            var filter = Builders<Product>.Filter.Empty;
            var productDoc = Global.ProductsCollection.Find(filter).ToList();
            List<Product> items = new List<Product>();
            foreach (var item in productDoc)
            {
                items.Add(item);
            }
            return items;
        }
        public static Product FetchItems(string id)
        {
            var filter = Builders<Product>.Filter.Eq(doc => doc.Id, id);
            var item = Global.ProductsCollection.Find(filter).FirstOrDefault();
            return item;
        }

        public static List<Product> FetchItems(Category category)
        {
            var filter = Builders<Product>.Filter.Eq(doc => doc.Category, category);
            var productDoc = Global.ProductsCollection.Find(filter).ToList();
            List<Product> items = new List<Product>();
            foreach (var item in productDoc)
            {
                items.Add(item);
            }
            return items;
        }
    }
}
