using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static Basket basket = new Basket();
        public static List<Product> products = new List<Product>();
        static void Main(string[] args)
        {
            Console.WriteLine("Чтобы войти нажмите 1.\nНажмите другую клавишу,если хотите зарегистрироваться");
            string a = Console.ReadLine();

            if (a == "1")
            {
                User user1 = new User();

                Console.WriteLine("Введите логин: ");
                if (user1.Login != Console.ReadLine())
                {
                    Console.WriteLine("Такой пользователь не найден");
                }

                else
                {
                    Console.WriteLine("Введите пароль: ");
                    if (user1.Password != Console.ReadLine()) { Console.WriteLine("Неверный пароль!"); }
                }
            }
            else
            {
                User user2 = new User();

                Console.WriteLine("Введите логин: ");
                user2.Login = Console.ReadLine();

                Console.WriteLine("Придумайте пароль: ");
                user2.Password = Console.ReadLine();
            }
            int n = 0;
            Console.WriteLine("Введите 1 для выбора товара, 2 для оплаты");
            n=Console.Read();
            switch(n){
                case 1: Choose();
                    break;
                case 2:
                    Payment();
                    break;
            }
        }

        public static void Choose()
        {
            int i = 0;
            while (i != products.Count)
            {

                Console.WriteLine(products[i]);
                i++;
            }
            int j = 0;
            int choise=-1;
            Console.WriteLine("Введите номер товара, который хотите добавить в корзину");
            while(j<10 && choise <0)
            {
                choise= int.Parse(Console.ReadLine());
                j++;
                
                basket.Tovars[j] = products[choise].Id;
            }
        }
        public static void Payment()
        {
            double cost = 0;
            for(int i=0; i<((basket.tovars).Length); i++)
            {
                cost += products[basket.tovars[i]].Price;
            }
            Console.WriteLine("К оплате: " + cost + "тенге");
        }


    }

}