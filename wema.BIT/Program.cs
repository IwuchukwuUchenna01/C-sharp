using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using wema.BIT.modules;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using wema.BIT;
using wema.BIT.models;
using System.Transactions;

namespace Wema.Bit
{
    public class User
    {

        public static void Main(string[] args)
        {
            List<Payment> list = new List<Payment>()
                {
                new Payment() { UserId = 1, PaymentId = 12, PayAmount= 12200, TransactionDate = DateTime.Now},
                new Payment() { UserId = 2, PaymentId = 13,PayAmount=132000, TransactionDate = DateTime.Now},
                new Payment() { UserId = 3,PaymentId=14, PayAmount=134000,TransactionDate = DateTime.Now},
                new Payment() { UserId = 4,PaymentId=15, PayAmount=12400,TransactionDate = DateTime.Now},
                new Payment(){ UserId = 5,PaymentId=16, PayAmount=20000, TransactionDate = DateTime.Now}
                };
            List<Users> listItems = new List<Users>()
                {
                    new Users() { UserId = 1, FirstName = "Joe", LastName = "Udoka",
                        Email = "josephudokae@gmail.com", Payments = list.Where(x=> x.UserId == 1 ).ToList()},
                    new Users() { UserId = 2, FirstName = "Paul", LastName = "Osatopeme",
                        Email = "judefacts@gmail.com", Payments = list.Where(x=> x.UserId == 2 ).ToList() },
                    new Users() { UserId = 3, FirstName = "james", LastName = "Doinghisbest",
                        Email = "jamesDoinghisbest@gmail.com", Payments = list.Where(x=> x.UserId == 3 ).ToList() },
                    new Users() { UserId = 4, FirstName = "Nurudeen", LastName = "bestintrying",
                        Email = "nurudeenbestintrying.com", Payments = list.Where(x=> x.UserId == 4 ).ToList() },
                    new Users() { UserId = 5, FirstName = "uche", LastName = "sabiboy",
                        Email = "uchesabiboy@gmail.com", Payments = list.Where(x=> x.UserId == 5 ).ToList() }

            };
            List<Account> AccountStatement = new List<Account>() {
                new Account() { UserId = 1, Credit = 4000, AccountName ="Joe Udoka", AvailableBalance = 200000, PhoneNumber = 08188576490, AccountNumber = 08165789323, BVN = 23456789079656 },
                new Account() { UserId = 2,Credit = 5000,AccountName ="Joe Udoka", AvailableBalance = 12000000, PhoneNumber = 08178999543, AccountNumber = 07685432156, BVN = 44556688998432 },
            };



            var userPaymnets = list.Where(x => x.UserId == 1);
            var u = new List<User>();



            var json = JsonConvert.SerializeObject(userPaymnets, Formatting.Indented);

            //SerializeObject(userPaymnets, Formatting.Indented);

            foreach (var user in listItems)
            {
                if (user.FirstName == "Tomi" || user.LastName == "Johnson") Console.WriteLine("First Name : " + user.FirstName + " Last Name : " + user.LastName);

            }

            foreach (var item in listItems)
            {
                //converts the firt and last name to proper case
                TextInfo FirstName1 = CultureInfo.CurrentCulture.TextInfo;
                string FirstName2 = FirstName1.ToTitleCase(item.FirstName);
                TextInfo LastName1 = CultureInfo.CurrentCulture.TextInfo;
                string LastName2 = LastName1.ToTitleCase(item.LastName);
                Console.WriteLine($" UserId:{item.UserId}\n Email:{item.Email}\n FirstName: {FirstName2} \n LastName: {LastName2}  ");
                foreach (var x in list)
                   
                {

                    if (x.UserId == item.UserId)
                    {
                        Console.WriteLine($" Debit: ${x.PayAmount}\n PaymentId: {x.PaymentId} \n Transaction date:{x.TransactionDate} ");
                        foreach (var y in AccountStatement)
                        {
                            if (y.UserId == item.UserId) Console.WriteLine($" Available balance: ${y.AvailableBalance - x.PayAmount} \n account details:{y.AccountNumber} ");


                        }
                    };

                }
                
                Console.WriteLine("----------------------------------------------------------");
                //Transaction date:{ DateTime.Now}
            }
        }
    }
}


