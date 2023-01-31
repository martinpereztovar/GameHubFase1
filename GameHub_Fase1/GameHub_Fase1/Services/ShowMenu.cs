using GameHub_Fase1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameHub_Fase1.Services
{
    public class ShowMenu
    {
        public ShowMenu()
        {
        }

        public static void ShowFirstMenu()
        {
            Console.WriteLine("Bem-vindo(a), selecciona a opção desejada: ");
            Console.WriteLine("1 - Cadastrar usuario");
            Console.WriteLine("2 - Fazer Login");
        }
        public static void ShowMenuLogIn()
        {
            Console.WriteLine("Digite seu email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Digite sua senha: ");
            string password = Console.ReadLine();
        }

        public static void ShowMenuGames()
        {
            Console.WriteLine("Digite qual jogo deseja: ");
            Console.WriteLine("1 - Jogo da velha");
            Console.WriteLine("2 - Batalha naval");
            int option = int.Parse(Console.ReadLine());

        }
    }
}
