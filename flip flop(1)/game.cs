using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flip_flop_1_
{
    class game
    {
        public static bool match(PictureBox p1, PictureBox p2)
        {
            if (p1.Tag == p2.Tag)
                return true;
            else
                return false;
        }
        
    }
}
