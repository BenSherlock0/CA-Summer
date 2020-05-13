using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaulSherlock_S00189970;

namespace PhoneDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneData database = new PhoneData();

            using (database)
            {
                Phone p1 = new Phone("Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg") { ID =1};
                Phone p2 = new Phone("iPhone 11", 600, "IOS", "/images/apple.png", "/images/iphone11.jpg") { ID = 2 };

                database.Phones.Add(p1);
                database.Phones.Add(p2);

                Console.WriteLine("Added Phones");

                database.SaveChanges();

                Console.WriteLine("Saved to DataBase");

            }
        }
    }
}
