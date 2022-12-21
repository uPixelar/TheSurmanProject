using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace ServiceLayer {
    public class UserSystem {
        protected static string username;
        protected static string password;

        public string UserName { get { return username; } set { username = value; } }
        public string Password { set { password = value; } }

        public bool Login(string username, string password) {
            surmanEntities entities = new surmanEntities();
            entities.tb_users.Where(row => row.username == username);
            return false;
        }

        public void Register(string username, string password) {
            surmanEntities entities = new surmanEntities();
            tb_users user = new tb_users();
            user.groupId = entities.tb_groups.First(row => row.groupName == "User").groupId;
            user.username = username;
            user.password = Hash(password);
            user = entities.tb_users.Add(user);
            Debug.WriteLine(user.password);
            entities.SaveChanges();
            username = user.username;
            password = user.password;
            
        }

        public string Hash(string password) {
            // Create salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            // Create hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            var hash = pbkdf2.GetBytes(20);

            // Combine salt and hash
            var hashBytes = new byte[16 + 20];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // Convert to base64
            var base64Hash = Convert.ToBase64String(hashBytes);

            // Format hash with extra information
            return string.Format("$MYHASH$V1${0}${1}", 10000, base64Hash);
        }
    }
}
