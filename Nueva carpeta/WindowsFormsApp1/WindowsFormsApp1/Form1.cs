using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Timer timer1 = new Timer();
        public Form1()
        {
            Timer timer1 = new Timer();
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Start();
            timer1.Tick += (s, e) => {
                this.Hide();
                Form2 frm = new Form2();
                frm.Show(); ;
                timer1.Stop();
            };

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }


    }
}
