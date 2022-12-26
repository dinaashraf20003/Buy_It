using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using BCrypt.Net;
namespace DesktopStoreProject
{
    internal static class Program
    {
        [STAThread] 
        static void Main()
        { 

            MongoClient client = new MongoClient("mongodb+srv://mohagras:UChhyRePdxSMb5iY@cluster0.fg5pcpx.mongodb.net/store?retryWrites=true&w=majority\r\n");
            Global.Database = (MongoDatabaseBase)client.GetDatabase("store2");

            Global.ProductsCollection = (MongoCollectionBase<Product>)Global.Database.GetCollection<Product>("products");
            Global.OrdersCollection = (MongoCollectionBase<Order>)Global.Database.GetCollection<Order>("orders");
            Global.UsersCollection = (MongoCollectionBase<User>)Global.Database.GetCollection<User>("users");

            /*
             List<String> imgs = new List<String>();
             imgs.Add("https://images.canadagoose.com/image/upload/w_800,c_scale,f_auto,q_auto:best/v1670616267/product-image/7783M_25_a.jpg");
             imgs.Add("https://images.canadagoose.com/image/upload/w_1920,c_scale,f_auto,q_auto:best/v1670616267/product-image/7783M_25_fsph.jpg");
             Product prod1 = new Product("Toronto Boot", 750, 12, "Introducing the Toronto Boot—a versatile boot taking inspiration from its namesake, the innovative design focuses on performance and comfort.", imgs, Category.CLOTHES, "Canada Goose");

             List<OrderItem> list = new List<OrderItem>();

             OrderItem orditem1 = prod1.CreateOrderItem(2);
             list.Add(orditem1);
             Order order1 = new Order("USR-314", new DateTime(2022, 12, 23), list);
             //Global.OrdersCollection.InsertOne(order1);
             order1.UpdateStatus();

            User user1 = new User("Mohamed", "Smouha, Alexandria", "mohmhagras@gmail.com","+201277074935", "Egypt");
            user1.SetPassword("alx1991cairo#A");
            Global.UsersCollection.InsertOne(user1);

              var filter = Builders<User>.Filter.Eq(doc => doc.Email, "mohmhagras@gmail.com");
              var userDoc = Global.UsersCollection.Find(filter).FirstOrDefault();

              Console.WriteLine(userDoc.Id);
              Console.WriteLine(BCrypt.Net.BCrypt.Verify("alx1991cairo#A", userDoc.Password));


        // BCrypt.Net.BCrypt.Verify("password", hashedpassword);
          */
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}