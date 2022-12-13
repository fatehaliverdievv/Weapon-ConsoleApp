using System.ComponentModel.Design;
using Weapon_task.Models;

namespace Weapon_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Silah yaratmaq uchun silahin infolarini daxil edin. \nIlk once adini daxil edin : " );
            string weaponname=Console.ReadLine();
            Console.WriteLine("Silahin gulle tutumunu daxil edin : ");
            int bulletcapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Silahin hal hazirki gulle sayini daxil edin : ");
            int bulletcount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Silahin daraginin boshalma saniyesini daxil edin : ");
            int bullettime = Convert.ToInt32(Console.ReadLine());
            Weapon weapon = new Weapon(weaponname , bulletcapacity, bulletcount, bullettime, true);
            bool end = true;
            while (end)
            {
                Menu:
                Console.WriteLine("0. Informasiya almaq uchun \n1.Shoot metodunu ishe salmaq uchun \n2.Fire metodunu ishe salmaq uchun \n3.GetRemainCount metodunu isledir \n4.Reload metodu uchun \n5.ChangeFireMode metodu uchun \n6.Exit");
                int command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 0:
                        goto Menu;
                        break;
                    case 1:
                        Console.Clear();
                        weapon.Shoot();
                        break;
                    case 2:
                        Console.Clear();

                        weapon.Fire();
                        break;
                    case 3:
                        Console.Clear();
                        weapon.GetRemainCount();
                        break;
                    case 4:
                        Console.Clear();
                        weapon.Reload();
                        break;
                    case 5:
                        Console.Clear();
                        weapon.ChangeFireMod();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Proqram dayandi");
                        end = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong command daxil elediniz!!!");
                        goto Menu;
                        break;
                }
            }
         }
    }
}