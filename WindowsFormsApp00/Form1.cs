using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp00
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            pictureBox21.Hide();
            pictureBox22.Hide();
        }
        public int bagis = 2;


        private void B_Click(object sender, EventArgs e)
        {if (bagis % 2 == 1)
            {
                B.Hide();
                pictureBox21.Show();
            }
        else if (bagis % 2 == 0)
            {
                B.Hide();
                pictureBox22.Show();
            }
        }
    }
}
