using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUNS
{
    public class M4 : GunShooter
    {          
        public M4(int maxgullesayi) : base(maxgullesayi) 
        {            
            TotalBulletCount = maxgullesayi;
        }
    }
}
