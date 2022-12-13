using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ce205_hw3_gui.RBTree
{
    public class line
    {
        
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public Color warna { get; set; }
        /// <summary>
        /// The first parameter is the starting point for the line on the screen.
        /// The second parameter is where to draw a straight line from this point to another point on the screen.
        /// The third parameter is where to draw a curve from this point to another point on the screen.
        /// And finally, there's one last parameter which sets what color should be drawn at this location on the screen
        //////////////////////////////////////////////////
        /// The code is used to draw a line between the coordinates (x1, y1) and (x2, y2).
        /// The Color variable warna is assigned the value of c.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="c"></param>
        public line(int x1, int y1, int x2, int y2, Color c)
        {
            warna = c;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
    }
}
