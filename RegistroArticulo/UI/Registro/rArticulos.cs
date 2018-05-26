using RegistroArticulo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroArticulo.UI.Registro
{
    public partial class rArticulos : Form
    {
        public rArticulos()
        {
            InitializeComponent();
        }

        private Articulos LlenarClase()
        {

            Articulos art = new Articulos();

            art.ArticuloId = Convert.ToInt32(IdnumericUpDown.Value);
            art.Descripcion = DescripciontextBox.Text;
            art.Precio = PreciotextBox.Text;
            art.FechaVencimiento = VencimientodateTimePicker.Value;
            art.CantidadCotizada = Convert.ToInt32(CantCottextBox.Text);

            return art;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);
           Articulos articulo = BLL.ArticulosBLL.Buscar(id);

            if (articulo != null)
            {

                DescripciontextBox.Text = articulo.Descripcion;
                PreciotextBox.Text = articulo.Precio;
                VencimientodateTimePicker.Text = articulo.FechaVencimiento.ToString();
                CantCottextBox.Text = articulo.CantidadCotizada.ToString();

            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RegistroLibros_Load(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            Articulos articulo = LlenarClase();
            bool paso = false;

            //Determinar si es Guardar o Modificar
            if (IdnumericUpDown.Value == 0)
                paso = BLL.ArticulosBLL.Guardar(articulo);
            else
                paso = BLL.ArticulosBLL.Modificar(LlenarClase());

            //Informar el resultado
            if (paso)

                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            PreciotextBox.Clear();
            CantCottextBox.Clear();
            
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);

            if (BLL.ArticulosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
