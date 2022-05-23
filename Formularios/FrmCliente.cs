using RegistroCarpinteria.datos;
using RegistroCarpinteria.entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroCarpinteria.Formularios
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        private void limpiarCampos()
        {
            txtidCliente.Text = "";
            txtnombreCliente.Text = "";
            txtapellidoCliente.Text = "";
            txtdireccionCliente.Text = "";
        }

        private void llenarGrid()
        {
            DataTable datos = ClienteCAD.listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                listaCliente.DataSource = datos.DefaultView;
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente em = new Cliente();
                em.IdCliente1 = txtidCliente.Text.Trim().ToUpper();
                em.NomCliente1 = txtnombreCliente.Text.Trim().ToUpper();
                em.ApellidoCliente1 = txtapellidoCliente.Text.Trim().ToUpper();
                em.DirCliente = txtdireccionCliente.Text.Trim().ToUpper();

                if (ClienteCAD.guardar(em))
                {
                    llenarGrid();
                    limpiarCampos();
                    MessageBox.Show("Cliente agregado satisfactoriamente");
                }
                else
                {
                    MessageBox.Show("Dato existente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool consultado = false;
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Cliente em = ClienteCAD.consultar(txtidCliente.Text.Trim());
            if (em == null)
            {
                MessageBox.Show("No existe el codigo" + txtidCliente.Text);
                limpiarCampos();
                consultado = false;
            }
            else
            {
                txtidCliente.Text = em.IdCliente1;
                txtnombreCliente.Text = em.NomCliente1;
                txtapellidoCliente.Text = em.ApellidoCliente1;
                txtdireccionCliente.Text = em.DirCliente;
                consultado = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar el empleado");
            }
            else
            {
                try
                {
                    Cliente em = new Cliente();
                    em.IdCliente1 = txtidCliente.Text.Trim().ToUpper();
                    em.NomCliente1 = txtnombreCliente.Text.Trim().ToUpper();
                    em.ApellidoCliente1 = txtapellidoCliente.Text.Trim().ToUpper();
                    em.DirCliente = txtdireccionCliente.Text.Trim().ToUpper();

                    if (ClienteCAD.actualizar(em))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Cliente actualizado satisfactoriamente");
                        consultado = false;
                    }
                    else
                    {
                        MessageBox.Show("Fallo en la actualizacion :)");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!consultado)
            {
                MessageBox.Show("Debe consultar el cliente");
            }
            else if (DialogResult.Yes == MessageBox.Show(null, "Desea eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo))
            {
                try
                {
                    if (ClienteCAD.eliminar(txtidCliente.Text.Trim()))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Cliente eliminado satisfactoriamente");
                        consultado = false;
                    }
                    else
                    {
                        MessageBox.Show("Fallo en la eliminacion :)");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
