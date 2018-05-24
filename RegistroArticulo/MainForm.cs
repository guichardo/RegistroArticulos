using RegistroArticulo.UI.Consulta;
using RegistroArticulo.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroArticulo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rArticulos registro = new rArticulos();
            registro.MdiParent = this;
            registro.Show();
        }

        private void ArticulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cArticulos registro = new cArticulos();
            registro.MdiParent = this;
            registro.Show();
        }
    }
}
