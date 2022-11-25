using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            
            User name = new User();
            name.Name = Console.ReadLine();

            Console.WriteLine("Введите логин");

            User login = new User();
            login.Login = Console.ReadLine();

            Console.WriteLine("Вы оплатили подписку? (да/нет)");
            string resalt = Console.ReadLine();
                      
            switch (resalt)
            {
                case "да":
                   User premium = new User();
                   premium.IsPremium = true;
                   Console.WriteLine("У вас премиальный доступ");
                    break;
                case "нет":
                    User notPremium = new User();
                    notPremium.IsPremium = false;
                    Console.WriteLine("У вас нет приватного доступа, вы можете оформить подписку или пользоваться приложением бесплатно, но с рекламой");
                    ShowAds();
                    break; 
                default:
                    Console.WriteLine("Введенные данные неверны");
                    break;
            }
        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
