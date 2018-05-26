using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasCirculares
{
    public partial class Form1 : Form
    {
        Estructura sss = new Estructura();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClaseBase basee;
            basee = new ClaseBase(txtNombreBase.Text, Convert.ToInt32(txtTiempo.Text));
            sss.Agregar(basee);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ClaseBase basee;
            basee = new ClaseBase(txtNombreBase.Text, Convert.ToInt32(txtTiempo.Text));
            sss.Insertar(basee, Convert.ToInt32(txtInsertar.Text));
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            sss.EliminarUltimo();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtLista.Text = sss.listar();
        }

        private void btnEliminarInicio_Click(object sender, EventArgs e)
        {
            sss.EliminarInicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sss.Eliminar(txtNombreBase.Text);
        }
    }
}
