using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub_Fase1.Models
{
    public class SingUpUser
    {
        private List<User> users= new List<User>();

        public void SingUser(User user) 
        {
            users.Add(user);
        }

        public void ListUsers()
        {

        foreach (User user in users)
            {
                Console.WriteLine($"Nome = {user.Name}");
                Console.WriteLine($" Nickname = {user.NickName}");    
            }
        }
    }
}
