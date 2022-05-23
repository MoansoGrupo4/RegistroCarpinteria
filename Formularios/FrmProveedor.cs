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
    public partial class FrmProveedor : Form
    {
        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void limpiarCampos()
        {
            txtidProveedor.Text = "";
            txtnombreProveedor.Text = "";
            txtDireccionProveedor.Text = "";
            txttelefonoProveedor.Text = "";
        }

        private void llenarGrid()
        {
            DataTable datos = ProveedorCAD.listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                listaProveedor.DataSource = datos.DefaultView;
            }
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor em = new Proveedor();
                em.CodProveedor1 = txtidProveedor.Text.Trim().ToUpper();
                em.NomProveedor1 = txtnombreProveedor.Text.Trim().ToUpper();
                em.DirProveedor1 = txtDireccionProveedor.Text.Trim().ToUpper();
                em.TelfProveedor1 = txttelefonoProveedor.Text.Trim().ToUpper();

                if (ProveedorCAD.guardar(em))
                {
                    llenarGrid();
                    limpiarCampos();
                    MessageBox.Show("Proveedor agregado satisfactoriamente");
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
            Proveedor em = ProveedorCAD.consultar(txtidProveedor.Text.Trim());
            if (em == null)
            {
                MessageBox.Show("No existe el codigo" + txtidProveedor.Text);
                limpiarCampos();
                consultado = false;
            }
            else
            {
                txtidProveedor.Text = em.CodProveedor1;
                txtnombreProveedor.Text = em.NomProveedor1;
                txtDireccionProveedor.Text = em.DirProveedor1;
                txttelefonoProveedor.Text = em.TelfProveedor1;
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
                    Proveedor em = new Proveedor();
                    em.CodProveedor1 = txtidProveedor.Text.Trim().ToUpper();
                    em.NomProveedor1 = txtnombreProveedor.Text.Trim().ToUpper();
                    em.DirProveedor1 = txtDireccionProveedor.Text.Trim().ToUpper();
                    em.TelfProveedor1 = txttelefonoProveedor.Text.Trim().ToUpper();

                    if (ProveedorCAD.actualizar(em))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Proveedor actualizado satisfactoriamente");
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
                MessageBox.Show("Debe consultar el proveedor");
            }
            else if (DialogResult.Yes == MessageBox.Show(null, "Desea eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo))
            {
                try
                {
                    if (ProveedorCAD.eliminar(txtidProveedor.Text.Trim()))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Proveedor eliminado satisfactoriamente");
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
