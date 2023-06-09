using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUNS
{
    internal class AWP : GunShooter , IZoomeable
    {
        public AWP(int maxgullesayi) : base(maxgullesayi)
        {            
            TotalBulletCount = maxgullesayi;
        }

        public void Zoom () 
        {
            Console.WriteLine("Zoom..");
        }
    }
}
