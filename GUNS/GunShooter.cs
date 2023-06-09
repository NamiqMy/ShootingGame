using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUNS
{
    public abstract class GunShooter
    {
        public GunShooter(int maxgullesayi)
        {
            TotalBulletCount = maxgullesayi;
        }
        public int TotalBulletCount { get; set; }
        public int CurrentBulletCount { get; set;}


        public void Shoot()
        {
            CurrentBulletCount --;
            Console.WriteLine("Shooting..");
        }
        public void Reload()
        {            
            TotalBulletCount = CurrentBulletCount;
            Console.WriteLine("Reloading..");
        }
    }


    
}
