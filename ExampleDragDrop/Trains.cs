using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleDragDrop
{
    class Trains
    {

    }
    class Train : PictureBox
    {
        int id;
        public Train(int id, Control control, int x, int y)
        {
            this.id = id;
            this.Load("Train/p" + id.ToString() + "Armenian.png");
            control.Controls.Add(this);
            this.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Location = new System.Drawing.Point(x, y);
        }
    }
}
