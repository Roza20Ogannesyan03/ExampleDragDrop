using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleDragDrop
{
    public partial class FormMain : Form
    {
        Train t1;
        Train t2;
        public static Card moveCard = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card c1 = new Card(1, this);
            Card c2 = new Card(2, this);
            t1 = new Train(3, this, 400, 10);
            t2 = new Train(2, this, 400, 200);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (moveCard != null)  
            {
                if (moveCard.Bounds.IntersectsWith(t1.Bounds))
                {
                    moveCard = null;
                    //moveCard.Location = new Point(1000, 1000); 
                    MessageBox.Show("Пересеклись");
                }
            }
        }
    }
}
