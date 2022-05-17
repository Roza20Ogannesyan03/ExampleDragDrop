using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDropAuto
{
    public partial class Form1 : Form
    {
        ListBox temp = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSourseDrag_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSourseDrag.DoDragDrop(buttonSourseDrag.Text, DragDropEffects.Copy);
        }


        private void textBoxTargetDrop_DragDrop(object sender, DragEventArgs e)
        {
            string text = (string)e.Data.GetData(DataFormats.Text);
            textBoxTargetDrop.Text = text;
        }

        private void textBoxTargetDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSourseDrag2_Click(object sender, EventArgs e)
        {
            buttonSourseDrag2.DoDragDrop(buttonSourseDrag2.Text, DragDropEffects.Copy);
        }

        private void pictureBoxSourseDrag_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox temp = sender as PictureBox;
            temp.DoDragDrop(temp.Image, DragDropEffects.Copy);
        }

        private void panelTargetDrag_DragDrop(object sender, DragEventArgs e)
        {
            Image img = (Image)e.Data.GetData(DataFormats.Bitmap);
            panelTargetDrag.BackgroundImage = img;
        }

        private void panelTargetDrag_DragEnter(object sender, DragEventArgs e)
        {
            //проверить тип данных для перетаскивания
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        private void listBoxColors_MouseDown(object sender, MouseEventArgs e)
        {
            temp = sender as ListBox;
            temp.DoDragDrop(temp.SelectedIndex.ToString(), DragDropEffects.Copy);
        }

        private void listBoxColors_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void listBoxFruits_DragDrop(object sender, DragEventArgs e)
        {
            int index = Convert.ToInt32(e.Data.GetData(DataFormats.Text));
            // тупой вариант
            //string tempstr = (string)listBoxColors.Items[index];
            //listBoxColors.Items[index] = listBoxFruits.Items[index];
            //listBoxFruits.Items[index] = tempstr;

            // умный вариант
            ListBox sourse = temp;
            ListBox target = sender as ListBox;
            if(sourse != target)
            {
                string tempstr = (string)sourse.Items[index];
                sourse.Items[index] = target.Items[index];
                target.Items[index] = tempstr;
            }
        }
    }
}
