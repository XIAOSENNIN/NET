using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hola_mundo_wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "")
            {
                MessageBox.Show("Hola " + txt_nombre.Text);
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
            
        }
    }
}
