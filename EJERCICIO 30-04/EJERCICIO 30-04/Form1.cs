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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_resultado_Click(object sender, EventArgs e)
        {
            if (tb_peso.Text != "" && tb_tiempo.Text != "" && cb_opc.Text != "")
            {
                double Resultado = 0;
                if (rb_peleador.Checked == true)
                {
                    Peleador p = new Peleador();
                    p.Peso = double.Parse(tb_peso.Text);
                    if (cb_opc.Text == "Segundos")
                    {
                        p.Minutos = double.Parse(tb_tiempo.Text) / 60;
                    }
                    else if (cb_opc.Text == "Minutos")
                    {
                        p.Minutos = double.Parse(tb_tiempo.Text);
                    }
                    else
                    {
                        p.Minutos = double.Parse(tb_tiempo.Text) * 60;
                    }
                    Resultado = p.CalcularCalorias();

                }
                else
                {

                    Futbolista f = new Futbolista();
                    f.Peso = double.Parse(tb_peso.Text);
                    if (cb_opc.Text == "Segundos")
                    {
                        f.Minutos = double.Parse(tb_tiempo.Text) / 60;
                    }
                    else if (cb_opc.Text == "Minutos")
                    {
                        f.Minutos = double.Parse(tb_tiempo.Text);
                    }
                    else
                    {
                        f.Minutos = double.Parse(tb_tiempo.Text) * 60;
                    }
                    Resultado = f.CalcularCalorias();
                }
                //MessageBox.Show("las calorias son" + Resultado.ToString(), "Resultado ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form_Mostrar miform = new Form_Mostrar();
                miform.mensaje = "las calorias quemadas son" + Resultado.ToString();
                miform.Show();  

            }
            else
            {
                MessageBox.Show("Debe ingresar datos requeridos para continuar ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tb_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones f = new funciones();
            if (f.solo_numeros(e.KeyChar) == 0 )
            {
                e.Handled = true;
            }
        }

        private void tb_tiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones f = new funciones();
            if (f.solo_numeros(e.KeyChar) == 0)
            {
                e.Handled = true;
            }
        }
    }
}

