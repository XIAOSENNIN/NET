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

            double interes = 0;
            double cuotaInteres = 0;

            double cuotaSinInteres = 0;
            int mes = 0;

            if (rut != "" && rut_digito != "" && montotext != "" && ( chb_desgravamen.Checked == true || chb_terremoto.Checked == true || chb_incendio.Checked == true))
            {
                double monto = double.Parse(montotext);

                if (rut_digito.Length<=1)
                {
                    if (cb_plazo.Text != "")
                    {
                        if (rut_digito.Length < 7 && rut_digito.Length > 9)
                        {
                            MessageBox.Show("Ingrese un RUT valido.", "Error");
                        }
                        else
                        {
                            if (cb_plazo.Text == "12 meses")
                            {
                                mes = 12;
                            }
                            cuotaSinInteres = monto / mes;

                            interes = (monto * 1.68) / 100;
                            cuotaInteres = cuotaSinInteres + interes;

                            if (chb_desgravamen.Checked || chb_terremoto.Checked)
                            {
                                cuotaInteres = cuotaInteres + (cuotaInteres * 0.0056) / 100;
                            }
                            else
                            {
                                cuotaInteres = cuotaInteres + (cuotaInteres * 0.0088) / 100;
                            }

                            double total = (cuotaInteres * mes);

                            Form_Simulacion miform = new Form_Simulacion();


                            miform.mensaje = $"RUT: {rut}\n Monto solicitado: {montotext}\n Plazo: {cb_plazo.Text}\n Valor cuota: {cuotaInteres}\n Monto total: {total}";

                            miform.Show();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un plazo de tiempo.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un verificador valido.", "Error");
                }
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
