using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopStoreProject.Models
{
    internal class CreateProductAdmin
    {
        public static void Create(string name, float price, int stock, string description, List<String> images, Category category, string brand)
        {
            Product product = new Product(name, price, stock, description, images, category, brand);
            Global.ProductsCollection.InsertOne(product);
        }
    }
}
