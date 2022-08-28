using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DostApp
{
    public partial class attendantInterface : Form
    {
        public attendantInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            saleInterface f2 = new saleInterface();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Are you sure you want to Logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
                this.Hide();
                Attendant f4 = new Attendant();
                f4.Show();
           };
        }
    }
}
