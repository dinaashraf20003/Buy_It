
using MongoDB.Driver;

namespace DesktopStoreProject
{
    static class Global
    {
        public static MongoDatabaseBase Database;
        public static MongoCollectionBase<User> UsersCollection;
        public static MongoCollectionBase<Product> ProductsCollection;
        public static MongoCollectionBase<Order> OrdersCollection;
    }
}
