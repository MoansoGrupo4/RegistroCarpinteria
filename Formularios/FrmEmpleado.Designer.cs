
namespace RegistroCarpinteria.Formularios
{
    partial class FrmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtidEmpleado = new System.Windows.Forms.TextBox();
            this.txtnombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtFuncionEmpleado = new System.Windows.Forms.TextBox();
            this.txtapellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtedadEmpleado = new System.Windows.Forms.TextBox();
            this.txtdocumentoEmpleado = new System.Windows.Forms.TextBox();
            this.txtdireccionEmpleado = new System.Windows.Forms.TextBox();
            this.dtfechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.listaEmpleado = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FICHA EMPLEADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Funcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Documento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Edad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha Nac:";
            // 
            // txtidEmpleado
            // 
            this.txtidEmpleado.BackColor = System.Drawing.Color.Gray;
            this.txtidEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidEmpleado.Location = new System.Drawing.Point(129, 111);
            this.txtidEmpleado.Name = "txtidEmpleado";
            this.txtidEmpleado.Size = new System.Drawing.Size(118, 23);
            this.txtidEmpleado.TabIndex = 9;
            // 
            // txtnombreEmpleado
            // 
            this.txtnombreEmpleado.BackColor = System.Drawing.Color.Gray;
            this.txtnombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreEmpleado.Location = new System.Drawing.Point(129, 152);
            this.txtnombreEmpleado.Name = "txtnombreEmpleado";
            this.txtnombreEmpleado.Size = new System.Drawing.Size(118, 23);
            this.txtnombreEmpleado.TabIndex = 10;
            // 
            // txtFuncionEmpleado
            // 
            this.txtFuncionEmpleado.BackColor = System.Drawing.Color.Gray;
            this.txtFuncionEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionEmpleado.Location = new System.Drawing.Point(129, 234);
            this.txtFuncionEmpleado.Name = "txtFuncionEmpleado";
            this.txtFuncionEmpleado.Size = new System.Drawing.Size(118, 23);
            this.txtFuncionEmpleado.TabIndex = 12;
            // 
            // txtapellidoEmpleado
            // 
            this.txtapellidoEmpleado.BackColor = System.Drawing.Color.Gray;
            this.txtapellidoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidoEmpleado.Location = new System.Drawing.Point(129, 193);
            this.txtapellidoEmpleado.Name = "txtapellidoEmpleado";
            this.txtapellidoEmpleado.Size = new System.Drawing.Size(118, 23);
            this.txtapellidoEmpleado.TabIndex = 11;
            // 
            // txtedadEmpleado
            // 
            this.txtedadEmpleado.BackColor = System.Drawing.Color.Gray;
            this.txtedadEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtedadEmpleado.Location = new System.Drawing.Point(129, 357);
            this.txtedadEmpleado.Name = "txtedadEmpleado";
            this.txtedadEmpleado.Size = new System.Drawing.Size(118, 23);
            this.txtedadEmpleado.TabIndex = 15;
            // 
            // txtdocumentoEmpleado
            // 
            this.txtdocumentoEmpleado.BackColor = System.Drawing.Color.Gray;
            this.txtdocumentoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumentoEmpleado.Location = new System.Drawing.Point(129, 316);
            this.txtdocumentoEmpleado.Name = "txtdocumentoEmpleado";
            this.txtdocumentoEmpleado.Size = new System.Drawing.Size(118, 23);
            this.txtdocumentoEmpleado.TabIndex = 14;
            // 
            // txtdireccionEmpleado
            // 
            this.txtdireccionEmpleado.BackColor = System.Drawing.Color.Gray;
            this.txtdireccionEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccionEmpleado.Location = new System.Drawing.Point(129, 275);
            this.txtdireccionEmpleado.Name = "txtdireccionEmpleado";
            this.txtdireccionEmpleado.Size = new System.Drawing.Size(118, 23);
            this.txtdireccionEmpleado.TabIndex = 13;
            // 
            // dtfechaNacimiento
            // 
            this.dtfechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaNacimiento.Location = new System.Drawing.Point(129, 399);
            this.dtfechaNacimiento.Name = "dtfechaNacimiento";
            this.dtfechaNacimiento.Size = new System.Drawing.Size(118, 23);
            this.dtfechaNacimiento.TabIndex = 17;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Gray;
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadir.Image")));
            this.btnAñadir.Location = new System.Drawing.Point(254, 480);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(40, 40);
            this.btnAñadir.TabIndex = 20;
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Gray;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(487, 480);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(40, 40);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gray;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(603, 480);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Gray;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(371, 480);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(40, 40);
            this.btnConsultar.TabIndex = 23;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // listaEmpleado
            // 
            this.listaEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaEmpleado.Location = new System.Drawing.Point(272, 114);
            this.listaEmpleado.Name = "listaEmpleado";
            this.listaEmpleado.Size = new System.Drawing.Size(543, 308);
            this.listaEmpleado.TabIndex = 18;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(830, 560);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.listaEmpleado);
            this.Controls.Add(this.dtfechaNacimiento);
            this.Controls.Add(this.txtedadEmpleado);
            this.Controls.Add(this.txtdocumentoEmpleado);
            this.Controls.Add(this.txtdireccionEmpleado);
            this.Controls.Add(this.txtFuncionEmpleado);
            this.Controls.Add(this.txtapellidoEmpleado);
            this.Controls.Add(this.txtnombreEmpleado);
            this.Controls.Add(this.txtidEmpleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmpleado";
            this.Text = "FrmEmpleado";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtidEmpleado;
        private System.Windows.Forms.TextBox txtnombreEmpleado;
        private System.Windows.Forms.TextBox txtFuncionEmpleado;
        private System.Windows.Forms.TextBox txtapellidoEmpleado;
        private System.Windows.Forms.TextBox txtedadEmpleado;
        private System.Windows.Forms.TextBox txtdocumentoEmpleado;
        private System.Windows.Forms.TextBox txtdireccionEmpleado;
        private System.Windows.Forms.DateTimePicker dtfechaNacimiento;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView listaEmpleado;
    }
}