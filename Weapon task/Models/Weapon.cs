using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_task.Models
{
    internal class Weapon
    {
        string _weaponName;
        int _bulletCapacity;
        int _bulletCount;
        public bool AutoMode;
        int _bullettime;
        int onebullettime;
        public string WeaponName
        {
            get { return _weaponName; }
            set 
            {
                if (value == "" || value==null)
                {
                    throw new Exception("Null ola bilmez");
                }
                else
                {
                    _weaponName = value;
                }
            }
        }

        public int BulletCapacity
        {
            get { return _bulletCapacity; }
            set 
            {
                if (value > 0)
                {
                    _bulletCapacity = value;
                }
                else
                {
                    throw new Exception("Duzgun gulle tutumu daxil edin");
                }
            }
        }
        public int BulletCount
        {
            get { return _bulletCount; }
            set 
            { 
                if(value>=0 && BulletCapacity >= value)
                {
                    _bulletCount = value; 
                }
                else
                {
                    throw new Exception("Duzgun gulle sayi daxil edin");
                }
            }
        }
        public int BulletTime
        {
            get { return _bullettime; }
            set
            {
                if (value > 0)
                {
                    _bullettime = value;
                }
                else
                {
                    throw new Exception("Duzgun gulle tutumu daxil edin");
                }
            }
        }
        public Weapon(string weaponname, int bulletcapacity, int bulletcount, int bullettime, bool automode) 
        {
            WeaponName = weaponname;
            BulletCapacity = bulletcapacity;
            BulletCount = bulletcount;
            BulletTime= bullettime;
            AutoMode = automode;
            onebullettime = bulletcapacity / bullettime;
            
        }
        public void Shoot()
        {
            if (BulletCount > 0)
            {
                BulletCount--;
                Console.WriteLine("Bir gulle atildi " + "qalan gulle : " + BulletCount);
            }
            else
            {
                Console.WriteLine("Atilacaq gulle yoxdu,gulle sayi : " + BulletCount);
            }
        }
        public void Fire()
        {
            if (AutoMode == false)
            {
                Shoot();
            }
            else if(AutoMode == true)
            {
                if(BulletCount > 0)
                {
                    int remainingbullettime = BulletCount * onebullettime;
                    Console.WriteLine("butun gulleler ateshlendi , Ateshlenme vaxti : " + remainingbullettime);
                    BulletCount = 0;
                }
                else
                {
                    Console.WriteLine("Gulle yoxdu : " + BulletCount);
                    wrongcommand:
                    Console.WriteLine("Gulle bitdi gore , reload elemek isteyirsiniz?(he/yox)");
                    string answer = Console.ReadLine();
                    if (answer.ToLower().Trim() == "he")
                    {
                        Reload();
                    }
                    else if (answer.ToLower().Trim()=="yox")
                    {
                        Console.WriteLine("Reload olunmadi");
                    }
                    else
                    {
                        Console.WriteLine("Duzgun command daxil ele!!");
                        goto wrongcommand;
                    }
                }
            }
        }
        public void ChangeFireMod()
        {
            if(AutoMode == false)
            {
                AutoMode = true;
            }
            else
            {
                AutoMode= false;
            }
            Console.WriteLine("Atish modu deyishdirildi");
        }
        public void GetRemainCount()
        {
            int remaincount = BulletCapacity - BulletCount;
            Console.WriteLine("Daragin tam dolmasi ucun lazim olan gulle sayi : " + remaincount);
        }
        public void Reload()
        {
            BulletCount = BulletCapacity;
            Console.WriteLine("Gulleniz reload olundu , hal hazirda olan gulle sayi " + BulletCount);
        }
    }
}
