using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GameHub_Fase1.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }

        public User()
        {
        }

        public User(string name, string email, string password, string nickName)
        {
            Name = name;
            Email = email;
            Password = password;
            NickName = nickName;
        }

        //public static void AddUser(User user) => users.Add(user);

        public static void AddUser(User user, List<User> users)
        {
            users.Add(user);
        }


        public static void RemoveUser(User user, List<User> users)
        {
            users.Remove(user);
        }
    }
}
