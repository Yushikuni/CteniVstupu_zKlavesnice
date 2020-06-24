using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lekce_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tlačítko bylo stisknuto :)");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) //klávesa mezera na klávesnici
            {
                button1.PerformClick();
            }
            else if(e.KeyCode == Keys.NumPad0) //klávesa 0 na numerické klávesnici
            {
                button1.PerformClick();
            }
        }
    }
}
