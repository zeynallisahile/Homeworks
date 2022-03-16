using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {

            string username = "";
            string password;
            User user = new User(username);
            do
            {
                Console.Write("Istifadeci adini daxil edin: ");
                username = Console.ReadLine();
                user.UserName = username;
                if (user.UserName == null)
                    Console.WriteLine("Istifadeci adi uzunluqu min 6 dan kicik max 25 den boyuk ola bilmez ");
            } while (user.UserName == null);
            do
            {
                Console.Write("Sifreni Daxil edin: ");
                password = Console.ReadLine();
                user.Password = password;
                if (user.Password == null)
                    Console.WriteLine("Sifrenin uzunluqu min 8 den kicik max 25 den boyuk ola bilmez ve daxilinde min 1 boyuk, min 1 kicik herf ve min 1 reqem olmalidir");
            } while (user.Password == null);
        }
    }
}
    
