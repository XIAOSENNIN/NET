using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_30_04
{
    public partial class Form_Mostrar : Form
    {
        public string mensaje;
        public Form_Mostrar()
        {
            InitializeComponent();
        }

        private void Form_Mostrar_Load(object sender, EventArgs e)
        {
            lbl_resultado.Text = mensaje;
        }
    }
}
