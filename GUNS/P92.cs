using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUNS
{
    public class P92 : GunShooter , IZoomeable
    {
        public P92(int maxgullesayi) : base(maxgullesayi) 
        {
            TotalBulletCount = maxgullesayi;
        }

        public void Zoom()
        {
            Console.WriteLine("Zoom..");
        }
    }
}
