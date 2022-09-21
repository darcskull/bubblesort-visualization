using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace bubblesort
{
    class DrawArray
    {
        public int x, y;
        public String Text;
        public int Size { get; set; }
        public Color Color { get; set; }
        public Color Textcolor { get; set; }
        public  void Draw(int x, int y, int size)
        {
            
            Graphics g = Form1.ActiveForm.CreateGraphics();
            Brush b = new SolidBrush(Color);
            Font format = new Font("Arial", 18);
            SolidBrush drawBrush = new SolidBrush(Textcolor);
            
            g.FillRectangle(b, x - size, y - size, 2 * size, 2 * size);
            g.DrawString(Text, format, drawBrush, x - size * 3 / 4, y - size / 2);

            this.x = x;
            this.y = y;
            this.Size = size;
        }
    }
}
