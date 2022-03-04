using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenarListasD
{
    public partial class Form1 : Form
    {
        List<Dato> datos = new List<Dato>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            //Copia el textbox a una variable
            string textoBuscar = textBox1.Text;
            //Busca si el texto ya existe dentro de datos
            int posicion = datos.FindIndex(n => n.texto == textoBuscar);
            //Si no existe el dato, lo creamos y lo agregamos a la lista
            if (posicion == -1)
            {
                Dato dato = new Dato();
                dato.numero = (int)numericUpDown1.Value;
                dato.texto = textBox1.Text;
                dato.fecha = dateTimePicker1.Value;
                datos.Add(dato);
            }
            //Si ya existe le sumamos 1 al número
            else
            {
                datos[posicion].numero++;
            }

            

        }

        private void Mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            dataGridView1.DataSource = datos;
            dataGridView1.Refresh();
        }

        private void buttonOrdenarNumero_Click(object sender, EventArgs e)
        {
            datos = datos.OrderBy(x => x.numero).ToList();
            Mostrar();
        }

        private void buttonOrdenarFecha_Click(object sender, EventArgs e)
        {
            datos = datos.OrderBy(f => f.fecha).ToList();
            Mostrar();
        }

        private void buttonOrdenarTexto_Click(object sender, EventArgs e)
        {
            datos = datos.OrderBy(t => t.texto).ToList();
            Mostrar();
        }
    }
}
