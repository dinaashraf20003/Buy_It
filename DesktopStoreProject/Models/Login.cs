using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopStoreProject
{
    internal class Login
    {
        public static bool CheckDetails(string email, string password)
        {
            var filter = Builders<User>.Filter.Eq(doc => doc.Email, email);
            var userDoc = Global.UsersCollection.Find(filter).FirstOrDefault();
            if (userDoc == null)
                throw new Exception("This Email is not Registered");
            if (!BCrypt.Net.BCrypt.Verify(password, userDoc.Password))
                throw new Exception("Password is not correct");
            return true;
        }
    }
}