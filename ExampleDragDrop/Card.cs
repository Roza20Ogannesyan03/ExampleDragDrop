using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleDragDrop
{
    public class Cards
    {
    }
    public class Card : PictureBox
    {
        int id;
        public Card(int id, Control control)
        {
            this.id = id;
            this.Load("Cards/p" + id.ToString() + ".png");
            control.Controls.Add(this);
            this.SizeMode = PictureBoxSizeMode.AutoSize;
            this.MouseDown += Card_MouseDown;
            this.MouseMove += Card_MouseMove;
            this.MouseUp += Card_MouseUp;
        }

        private void Card_MouseUp(object sender, MouseEventArgs e)
        {
            FormMain.moveCard = null;
        }

        int startX, startY;
        private void Card_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - startX;
                this.Top += e.Y - startY;
            }
        }

        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;
            FormMain.moveCard = this;
            //MessageBox.Show(id.ToString());
        }
    }
}
