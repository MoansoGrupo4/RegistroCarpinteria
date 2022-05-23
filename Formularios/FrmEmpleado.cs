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
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }
        private void FrmEmpleado_Load_1(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void limpiarCampos()
        {
            txtidEmpleado.Text = "";
            txtnombreEmpleado.Text = "";
            txtapellidoEmpleado.Text = "";
            txtFuncionEmpleado.Text = "";
            txtdireccionEmpleado.Text = "";
            txtdocumentoEmpleado.Text = "";
            txtedadEmpleado.Text = "";
            dtfechaNacimiento.Text = "";
        }

        private void llenarGrid()
        {
            DataTable datos = EmpleadoCAD.listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                listaEmpleado.DataSource = datos.DefaultView;
            }
        }

        bool consultado = false;
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Empleado em = EmpleadoCAD.consultar(txtidEmpleado.Text.Trim());
            if (em == null)
            {
                MessageBox.Show("No existe el codigo " + txtidEmpleado.Text);
                limpiarCampos();
                consultado = false;
            }
            else
            {
                txtidEmpleado.Text = em.IdEmpleado1;
                txtnombreEmpleado.Text = em.NomEmpleado1;
                txtapellidoEmpleado.Text = em.ApellidoEmpleado1;
                txtFuncionEmpleado.Text = em.FuncionEmpleado1;
                txtdireccionEmpleado.Text = em.DirEmpleado1;
                txtdocumentoEmpleado.Text = em.DNIEmpleado1.ToString();
                txtedadEmpleado.Text = em.EdadEmpleado1.ToString();
                dtfechaNacimiento.Text = em.FechaEmpleado1;
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
                    Empleado em = new Empleado();
                    em.IdEmpleado1 = txtidEmpleado.Text.Trim().ToUpper();
                    em.NomEmpleado1 = txtnombreEmpleado.Text.Trim().ToUpper();
                    em.ApellidoEmpleado1 = txtapellidoEmpleado.Text.Trim().ToUpper();
                    em.FuncionEmpleado1 = txtFuncionEmpleado.Text.Trim().ToUpper();
                    em.DirEmpleado1 = txtdireccionEmpleado.Text.Trim().ToUpper();
                    em.DNIEmpleado1 = Convert.ToInt32(txtdocumentoEmpleado.Text.Trim());
                    em.EdadEmpleado1 = Convert.ToInt32(txtedadEmpleado.Text.Trim());
                    em.FechaEmpleado1 = dtfechaNacimiento.Value.Year + "-" + dtfechaNacimiento.Value.Month + "-" + dtfechaNacimiento.Value.Day;

                    if (EmpleadoCAD.actualizar(em))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Empleado actualizado satisfactoriamente");
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
                MessageBox.Show("Debe consultar el empleado");
            }
            else if (DialogResult.Yes == MessageBox.Show(null, "Desea eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo))
            {
                try
                {
                    if (EmpleadoCAD.eliminar(txtidEmpleado.Text.Trim()))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Empleado eliminado satisfactoriamente");
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

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado em = new Empleado();
                em.IdEmpleado1 = txtidEmpleado.Text.Trim().ToUpper();
                em.NomEmpleado1 = txtnombreEmpleado.Text.Trim().ToUpper();
                em.ApellidoEmpleado1 = txtapellidoEmpleado.Text.Trim().ToUpper();
                em.FuncionEmpleado1 = txtFuncionEmpleado.Text.Trim().ToUpper();
                em.DirEmpleado1 = txtdireccionEmpleado.Text.Trim().ToUpper();
                em.DNIEmpleado1 = Convert.ToInt32(txtdocumentoEmpleado.Text.Trim());
                em.EdadEmpleado1 = Convert.ToInt32(txtedadEmpleado.Text.Trim());
                em.FechaEmpleado1 = dtfechaNacimiento.Value.Year + "-" + dtfechaNacimiento.Value.Month + "-" + dtfechaNacimiento.Value.Day;

                if (EmpleadoCAD.guardar(em))
                {
                    llenarGrid();
                    limpiarCampos();
                    MessageBox.Show("Empleado agregado satisfactoriamente");
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
    }
}
