using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towers
{
    public partial class Form1 : Form
    {
        HashSet<string> towns = new HashSet<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddTown_Click(object sender, EventArgs e)
        {
            string town = textBoxTowns.Text;
            towns.Add(town);
            showTowns();
            if (towns.Contains(town))
                MessageBox.Show("Уже есть!");
            else MessageBox.Show("Играем дальше");
        }

        private void showTowns()
        {
            listBoxTowns.Items.Clear();
            foreach (var town in towns)
            {
                listBoxTowns.Items.Add(town);
            }
        }
    }
}
