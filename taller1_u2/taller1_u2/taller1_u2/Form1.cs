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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rut = txt_rut.Text;
            string rut_digito = txt_rutdigito.Text;
            string montotext = txt_monto.Text;
            
            if (rut != "" && rut_digito != "" && montotext != "" && cb_plazo.Text != "")
            {
                if (chb_desgravamen.Checked == true || chb_terremoto.Checked == true || chb_incendio.Checked == true)
                {
                    int mes = 0;
                    double monto = double.Parse(montotext);

                    switch (cb_plazo.Text)
                    {
                        case "12 meses":
                            mes = 12;
                            break;
                        case "24 meses":
                            mes = 24;
                            break;
                        case "36 meses":
                            mes = 36;
                            break;
                        case "48 meses":
                            mes = 48;
                            break;
                        case "60 meses":
                            mes = 60;
                            break;
                        default:
                            break;
                    }

                    double cuotaSinInteres = monto / mes;
                    double interes = monto * 0.0168;
                    double cuotaInteres = cuotaSinInteres + interes;

                    if (chb_desgravamen.Checked == true)
                    {
                        cuotaInteres += monto * 0.00056;
                    }
                    if (chb_desgravamen.Checked == true)
                    {
                        cuotaInteres += monto * 0.00056;
                    }
                    if (chb_incendio.Checked == true)
                    {
                        cuotaInteres += monto * 0.00088;
                    }
                    Form_Simulacion resultado = new Form_Simulacion();
                    resultado.rut = rut;
                    resultado.dv = rut_digito;
                    resultado.monto = monto;
                    resultado.plazo = cb_plazo.Text;
                    resultado.cuota = cuotaInteres;
                    resultado.total = cuotaInteres * mes;

                    resultado.Show();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un seguro para continuar");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos para simular");
            }
        }

        private void txt_rut_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones f = new funciones();
            if (f.solo_numeros(e.KeyChar) == 0)
            {
                e.Handled = true;
            }
        }

        private void txt_rutdigito_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones f = new funciones();
            if (f.solo_numeros_k(e.KeyChar) == 0)
            {
                e.Handled = true;
            }
        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones f = new funciones();
            if (f.solo_numeros(e.KeyChar) == 0)
            {
                e.Handled = true;
            }
        }
    }
}
