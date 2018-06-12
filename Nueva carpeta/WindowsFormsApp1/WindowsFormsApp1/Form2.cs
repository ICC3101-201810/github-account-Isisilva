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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Peliculas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Peliculas frm = new Peliculas();
            
            frm.Show();
        }

        private void Actores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Actores frm = new Actores();
            frm.Show();
        }

        private void Directores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Directores frm = new Directores();
            frm.Show();
        }

        private void Productores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productores frm = new Productores();
            frm.Show();
        }

        private void Estudios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estudios frm = new Estudios();
            frm.Show();
            
        }

        private void productoresBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Size.Text <= 3)
            {
                MessageBox.Show("No ha puesto nada")
            }
            
        }
    }
}
