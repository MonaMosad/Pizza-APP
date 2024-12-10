using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            //label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void btnShowMenue_Click(object sender, EventArgs e)
        {
            Form frm = new frmPizzaMenue();
            frm.ShowDialog();
        }

       
    }
}
