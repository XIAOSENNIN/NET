using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            if (txt_patente.Text != "" && txt_marca.Text != "" && txt_modelo.Text != "")
            {
                Automovil auto = new Automovil();

                auto.patente = txt_patente.Text;
                auto.marca = txt_marca.Text;
                auto.modelo = txt_modelo.Text;  

                ProgCEntities bd = new ProgCEntities();

                bd.Automovil.Add(auto);
                bd.SaveChanges();
                mostrarAutomovil();

                txt_patente.Clear();
                txt_marca.Clear();
                txt_modelo.Clear(); 

                MessageBox.Show("Los datos se han guardado correctamente",
                    "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos para guardar",
                    "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarAutomovil();
        }

        private void mostrarAutomovil()
        {
            ProgCEntities bd = new ProgCEntities();

            var miConsulta = from mi_item in bd.Automovil
                             select mi_item;

            dataGridView1.DataSource = miConsulta.ToList();
            dataGridView1.Refresh();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow Fila = dataGridView1.Rows[e.RowIndex];

            txt_patente.Text = Fila.Cells[0].Value.ToString();
            txt_marca.Text = Fila.Cells[1].Value.ToString();
            txt_modelo.Text = Fila.Cells[2].Value.ToString();

            btn_insertar.Enabled = false;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            ProgCEntities bd = new ProgCEntities();

            var miConsulta = bd.Automovil.Find(txt_patente.Text);

            if (miConsulta != null)
            {
                bd.Automovil.Remove(miConsulta);
                bd.SaveChanges();
                mostrarAutomovil();

                txt_patente.Clear();
                txt_marca.Clear();
                txt_modelo.Clear();

                MessageBox.Show("Los datos se eliminaron correctamente",
                   "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btn_insertar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar los datos",
                   "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ProgCEntities bd = new ProgCEntities();

            var miConsulta = bd.Automovil.Find(txt_patente.Text);

            if (miConsulta != null)
            {
                miConsulta.patente = txt_patente.Text;
                miConsulta.marca = txt_marca.Text;
                miConsulta.modelo = txt_modelo.Text;

                bd.SaveChanges();
                mostrarAutomovil();

                txt_patente.Clear();
                txt_marca.Clear();
                txt_modelo.Clear();

                MessageBox.Show("Los datos se han modificados correctamente",
                   "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btn_insertar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar",
                   "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
