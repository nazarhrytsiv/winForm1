using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace WindowsForms.Interfaces
{
    interface IShape
    {
        void Move(Point update_centre);
        void Draw(Graphics graphics);
    }
}
