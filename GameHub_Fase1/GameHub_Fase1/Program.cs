using GameHub_Fase1.Models;
using GameHub_Fase1.Models.Game1;
using GameHub_Fase1.Models.Game2;
using GameHub_Fase1.Services;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace GameHub_Fase1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int option;
           
            
            List<User> users = new List<User>();
        

            do
            {
                ShowMenu.ShowFirstMenu();
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Digite seu nome: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Digite seu email: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Digite sua senha: ");
                    string password = Console.ReadLine();
                    Console.WriteLine("Digite seu nickName: ");
                    string nickname = Console.ReadLine();
                    SingUpUser singingup= new SingUpUser();
                    singingup.SingUser(new User(name, email, password, nickname));
                    Console.WriteLine($"Bem-vindo(a)!");
                    
                    ShowMenu.ShowMenuGames();
                    if (option == 1)
                    {
                        TicTacToe.Start();
                    }
                    else if (option == 2)
                    {
                        NavalBattle.Start();
                    }
                }
                else if (option == 2)
                {
                    ShowMenu.ShowMenuLogIn();
                    ShowMenu.ShowMenuGames();
                    if (option == 1)
                    {
                        TicTacToe.Start();
                    }
                    else if (option == 2)
                    {
                        NavalBattle.Start();
                    }
                }
                else
                {
                    Console.WriteLine("Opção incorreta. Tente novamente.");
                }
            } while (option != 1 && option != 2);

        }
    }
}
