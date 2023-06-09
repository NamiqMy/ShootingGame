using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUNS
{
    public class InSufficientBulletCountException : Exception
    {

        public InSufficientBulletCountException(string message)
            : base(message)
        {

        }
    }
    internal interface IZoomable
    {
        void Zoom();
    }
}
