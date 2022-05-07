using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace taller1_u2
{
    public partial class Form_Simulacion : Form
    {
        public string mensaje;
        public Form_Simulacion()
        {
            InitializeComponent();
        }

        private void Form_Simulacion_Load(object sender, EventArgs e)
        {
            lbl_res.Text = mensaje;
        }
    }
}
