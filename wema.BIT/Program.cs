using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using wema.BIT.modules;

namespace Wema.Bit
{
    /*namespace Wema.Bit.Users
    public class User
    {
        public static void Main(string[] args)

        {
            Console.WriteLine("Hello world!");

            Payment.Greet();
            Payment p = new Payment();
            p.GreetMe();

            string greet = p.GreetMe();

            Console.WriteLine(greet);

        }
    }

    public class Payment
    {
        public static void Greet()
        {
            Console.WriteLine("Good Afternoon");
        }

        public string GreetMe()
        {
            Console.WriteLine("Good Afternoon");

            return "Good Afternoon ma";

        }
    }*/
    public class User
    {   
    
        public static void Main(string[] args)
        {
            List<Users> listItems = new List<Users>()
                {
                    new Users() { UserId = 1, FirstName = "Joe", LastName = "Udoka",
                        Email = "josephudokae@gmail.com" },
                    new Users() { UserId = 2, FirstName = "Paul", LastName = "Osatopeme",
                        Email = "judefacts@gmail.com" },
                    new Users() { UserId = 3, FirstName = "james", LastName = "Doinghisbest",
                        Email = "jamesDoinghisbest@gmail.com" },
                    new Users() { UserId = 4, FirstName = "Nurudeen", LastName = "bestintrying",
                        Email = "nurudeenbestintrying.com" },
                    new Users() { UserId = 5, FirstName = "uche", LastName = "sabiboy",
                        Email = "uchesabiboy@gmail.com" }

            };
            List<Payment> list = new List<Payment>()
                {
                new Payment() { UserId = 1, PaymentId = 12, PayAmount= 12200},
                new Payment() { UserId = 2, PaymentId = 13,PayAmount=132000},
                new Payment() { UserId = 3,PaymentId=14, PayAmount=134000},
                new Payment() { UserId = 4,PaymentId=15, PayAmount=12400},
                new Payment(){ UserId = 5,PaymentId=16, PayAmount=20000}
                };
            foreach (var item in listItems) {
                //converts the firt and last name to proper case
                TextInfo FirstName1 = CultureInfo.CurrentCulture.TextInfo;
                string FirstName2 = FirstName1.ToTitleCase(item.FirstName);
                TextInfo LastName1 = CultureInfo.CurrentCulture.TextInfo;
                string LastName2 = LastName1.ToTitleCase(item.LastName);
                Console.WriteLine($" UserId:{item.UserId}\n Email:{item.Email}\n FirstName: {FirstName2} \n LastName: {LastName2} \n Transaction date:{DateTime.Now} ");
                foreach(var x in list)
                {
                    if (x.UserId == item.UserId) Console.WriteLine( $" Amount paid: ${x.PayAmount }\n PaymentId: {x.PaymentId}");
                    
                }
                Console.WriteLine("----------------------------------------------------------");



                /*foreach( var  item2 in list) {

                Console.WriteLine($"payment made by: {item.FirstName}{item2.PayAmount}");
                };*/

            }

            /*for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].UserId);

            }*/

        }
    }
}


