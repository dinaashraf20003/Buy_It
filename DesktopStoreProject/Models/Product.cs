using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DesktopStoreProject
{
    internal class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }


        private float price;

        [BsonElement("price")]
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }

        private int stock;
        [BsonElement("stock")]
        public virtual int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                if(value >= 0)
                {
                    stock = value;
                }
            }
        }

        [BsonElement("description")]
        public string Description {  get; set;  }

        [BsonElement("images")]
        public List<String> Images { get; set; } = new List<String>();

        [BsonElement("category")]
        [BsonRepresentation(BsonType.String)] 
        public Category Category { get; set; }


        [BsonElement("brand")]
        public string Brand { get; set; }


        public Product(string name, float price, int stock, string description, List<String> images, Category category, string brand)
        {
            Name = name;
            Price = price;
            Stock = stock;
            Description = description; 
            Images = images;
            Category = category;
            Brand = brand;
        }

        public Product(string id, string name, float price, int stock, string description, List<String> images, Category category, string brand)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
            Description = description;
            Images = images;
            Category = category;
            Brand = brand;
        }


        public OrderItem CreateOrderItem(int quantity)
        {
            if (Stock < quantity) 
            {
                throw new Exception("Not enough stock!");
            }

            return new OrderItem(quantity, Id, Name, Price, Stock, Description, Images, Brand, Category);

        }
    }
}
