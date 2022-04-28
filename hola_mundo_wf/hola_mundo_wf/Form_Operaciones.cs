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
    public partial class Form_Operaciones : Form
    {
        public Form_Operaciones()
        {
            InitializeComponent();
        }

        private void button1_Res_Click(object sender, EventArgs e)
        {
            if (txt_op1.Text != "" && txt_op2.Text != "") 
            {
                double op1 = double.Parse(txt_op1.Text);
                double op2 = double.Parse(txt_op2.Text);

                operaciones oper = new operaciones();

                double res = 0;

                if (rbtn_sumar.Checked == true)
                {
                    res = matematicas.Sumar(op1, op2);

                }
                else if (rbtn_resta.Checked == true)
                {
                    res = matematicas.Resta(op1, op2);
                }
                else if (rbtn_mult.Checked == true)
                {
                    res = oper.Multi(op1, op2);
                }
                else if (rbtn_div.Checked == true)
                {
                    res = oper.Div(op1, op2);
                }

                //MessageBox.Show("EL resultado es: " + res);
                Form_Resultado fr = new Form_Resultado();
                fr.resultado = res;
                fr.Show();

            }
            else
            {
                MessageBox.Show("Debe ingresar los datos correspondientes");
            }
        }


    }
}
