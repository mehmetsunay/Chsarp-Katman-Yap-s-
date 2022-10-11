using Business;
using Entity.Entities;
using System;

namespace KatmanYapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Databasedeki verileri çekmek için business üzerinden
            //döngü kullanarak ekrana verdim....
            
            CategoryMan cm = new CategoryMan();

            foreach (var item in cm.GetAll())
            {

                Console.WriteLine("ID: "+ item.categoryid + " " + "KATEGORİ ADI:" 
                    + item.categoryname);

            }
            //Verileri eklemek istiyorum ancak ilk etapta denediğim
            //pop kategorisi businessdekı şartımı sağlamadığı için işlem yapamasamda
            //türkü kategorisi için durum böyle değildi...
            categories kt = new categories();
                kt.categoryname = "Türkü";
            cm.BusAdd(kt);

            Console.Read();
        }
    }
}
