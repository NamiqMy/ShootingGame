using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUNS
{
    public class AK47 : GunShooter
    {
        public AK47(int maxgullesayi) : base(maxgullesayi)
        {            
            TotalBulletCount = maxgullesayi;
        }
    }
}
