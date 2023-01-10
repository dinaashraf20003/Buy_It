using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopStoreProject.Models
{
    class NewUser
    {
        public static void CreateNewAccount(string name, string address, string email, string phone, string country, string password)
        {
            var filter = Builders<User>.Filter.Eq(doc => doc.Email, email);
            var userDoc = Global.UsersCollection.Find(filter).FirstOrDefault();
            if (userDoc != null)
                throw new Exception("Email is already Registered");
            User user = new User(name, address, email, phone, country);
            user.SetPassword(password);
            Global.UsersCollection.InsertOne(user);
        }
    }
}