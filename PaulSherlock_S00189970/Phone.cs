using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulSherlock_S00189970
{
    public class Phone
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Operating_System { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public Phone(string name, double price, string operating_System,string oS_Image,string photo_Image)
        {
            Name = name;
            Price = price;
            Operating_System = operating_System;
            OS_Image = oS_Image;
            Phone_Image = photo_Image;
        }
        public Phone(double price)
        {
            Price = price;
        }

        public void IncreasePrice(double percentage)
        {
            Price += Price * percentage;
        }

    }
    public class PhoneData : DbContext
    {
        public PhoneData() : base("PhoneData") { }

        public DbSet<Phone> Phones { get; set; }

    }
}
