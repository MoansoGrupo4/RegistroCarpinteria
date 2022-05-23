using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroCarpinteria.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Funcion para acceder a cada panel de los formularios
        private void AbrirFrmInPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void icoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icoMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            icoMin.Visible = true;
            icoMax.Visible = false;
        }

        private void icoMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            icoMin.Visible = false;
            icoMax.Visible = true;
        }

        private void icoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmEmpleado());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmCliente());
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FrmProveedor());
        }
    }
}
