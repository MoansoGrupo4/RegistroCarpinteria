
namespace RegistroCarpinteria.Formularios
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.icoRestaurar = new System.Windows.Forms.PictureBox();
            this.icoMin = new System.Windows.Forms.PictureBox();
            this.icoMax = new System.Windows.Forms.PictureBox();
            this.icoCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoCerrar)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLateral.Controls.Add(this.btnEmpleado);
            this.panelLateral.Controls.Add(this.btnProveedor);
            this.panelLateral.Controls.Add(this.btnCliente);
            this.panelLateral.Controls.Add(this.pictureBox1);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(270, 600);
            this.panelLateral.TabIndex = 0;
            // 
            // btnProveedor
            // 
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.ForeColor = System.Drawing.Color.White;
            this.btnProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedor.Image")));
            this.btnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedor.Location = new System.Drawing.Point(0, 435);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(270, 50);
            this.btnProveedor.TabIndex = 3;
            this.btnProveedor.Text = "PROVEEDORES";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 346);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(270, 50);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "CLIENTES";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Maroon;
            this.panelTitulo.Controls.Add(this.icoRestaurar);
            this.panelTitulo.Controls.Add(this.icoMin);
            this.panelTitulo.Controls.Add(this.icoMax);
            this.panelTitulo.Controls.Add(this.icoCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(270, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(830, 40);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // icoRestaurar
            // 
            this.icoRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icoRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("icoRestaurar.Image")));
            this.icoRestaurar.Location = new System.Drawing.Point(746, 10);
            this.icoRestaurar.Name = "icoRestaurar";
            this.icoRestaurar.Size = new System.Drawing.Size(20, 20);
            this.icoRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoRestaurar.TabIndex = 3;
            this.icoRestaurar.TabStop = false;
            this.icoRestaurar.Click += new System.EventHandler(this.icoRestaurar_Click);
            // 
            // icoMin
            // 
            this.icoMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icoMin.Image = ((System.Drawing.Image)(resources.GetObject("icoMin.Image")));
            this.icoMin.Location = new System.Drawing.Point(772, 10);
            this.icoMin.Name = "icoMin";
            this.icoMin.Size = new System.Drawing.Size(20, 20);
            this.icoMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoMin.TabIndex = 2;
            this.icoMin.TabStop = false;
            this.icoMin.Visible = false;
            this.icoMin.Click += new System.EventHandler(this.icoMin_Click);
            // 
            // icoMax
            // 
            this.icoMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icoMax.Image = ((System.Drawing.Image)(resources.GetObject("icoMax.Image")));
            this.icoMax.Location = new System.Drawing.Point(772, 10);
            this.icoMax.Name = "icoMax";
            this.icoMax.Size = new System.Drawing.Size(20, 20);
            this.icoMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoMax.TabIndex = 1;
            this.icoMax.TabStop = false;
            this.icoMax.Click += new System.EventHandler(this.icoMax_Click);
            // 
            // icoCerrar
            // 
            this.icoCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icoCerrar.Image = ((System.Drawing.Image)(resources.GetObject("icoCerrar.Image")));
            this.icoCerrar.Location = new System.Drawing.Point(798, 10);
            this.icoCerrar.Name = "icoCerrar";
            this.icoCerrar.Size = new System.Drawing.Size(20, 20);
            this.icoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoCerrar.TabIndex = 0;
            this.icoCerrar.TabStop = false;
            this.icoCerrar.Click += new System.EventHandler(this.icoCerrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Gray;
            this.panelContenedor.Controls.Add(this.pictureBox6);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(270, 40);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(830, 560);
            this.panelContenedor.TabIndex = 2;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(232, 89);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(370, 370);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.Image")));
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(0, 256);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(270, 50);
            this.btnEmpleado.TabIndex = 4;
            this.btnEmpleado.Text = "EMPLEADOS";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icoRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoCerrar)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox icoRestaurar;
        private System.Windows.Forms.PictureBox icoMin;
        private System.Windows.Forms.PictureBox icoMax;
        private System.Windows.Forms.PictureBox icoCerrar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnEmpleado;
    }
}