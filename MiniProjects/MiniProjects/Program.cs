
using System;

namespace BankAccountApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Atm();
        }
        public static void Atm()
        {
            int money = 1000;
            Console.WriteLine("Welcome to the ATM!");
            Console.WriteLine("Etmek istediyiniz emeliyyati secin: (1: Balans, 2: Pul cekmek, 3: Pul yatirmaq, a: Cixis)");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("Balansiniz: " + money);
                Console.ReadLine();
            }
            else if (option == "2")
            {
                Console.WriteLine("Ne qeder pul cekmek isteyirsiniz?");
                int price = Convert.ToInt32(Console.ReadLine());
                if (price >= money)
                {
                    Console.WriteLine("Balansinizda kifayet qeder pul yoxdur");
                }
                else if (price <= money)
                {
                    money -= price;
                    Console.WriteLine("Emeliyyat ugurlu oldu. Yeni balansiniz: " + (money - price));
                }
                else
                {
                    Console.WriteLine("Emeliyyat ugurlu oldu. Yeni balansiniz: " + money);
                }
            }
            else if (option == "3")
            {
                Console.WriteLine("Ne qeder pul yatirmaq isteyirsiniz?");
                int addmoney = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Emeliyyat ugurlu oldu. Yeni balansiniz: " + (money + addmoney));
            }
            else if (option == "a")
            {
                Console.WriteLine("ATM-den cixis edilir...");
                Console.WriteLine("Xeyirle xercleyin");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Duzgun emeliyyat secin");
                Console.ReadLine();
            }
        }
    }
}