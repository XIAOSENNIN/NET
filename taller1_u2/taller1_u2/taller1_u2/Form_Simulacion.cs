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
        public string rut;
        public string dv;
        public double monto;
        public string plazo;
        public double cuota;
        public double total;

        //public string mensaje;

        public Form_Simulacion()
        {
            InitializeComponent();
        }

        private void Form_Simulacion_Load(object sender, EventArgs e)
        {
            lbl_res.Text = $"RUT: {rut}-{dv}\n" +
                           $"Monto solicitado: {monto.ToString()}\n" +
                           $"Plazo {plazo}\n" +
                           $"Valor cuota: {cuota.ToString()}\n" +
                           $"Total: {total.ToString()}";
        }
    }
}
