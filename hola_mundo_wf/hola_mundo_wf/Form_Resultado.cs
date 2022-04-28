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
    public partial class Form_Resultado : Form
    {
        public double resultado = 0;
        public Form_Resultado()
        {
            InitializeComponent();
        }

        private void Form_Resultado_Load(object sender, EventArgs e)
        {
            lbl_res.Text = resultado.ToString();
        }
    }
}
