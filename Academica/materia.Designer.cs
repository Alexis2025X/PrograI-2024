
namespace Academica
{
    partial class materia
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
            this.lblBuscarMateria = new System.Windows.Forms.Label();
            this.txtBuscarMateria = new System.Windows.Forms.TextBox();
            this.grdDatosAlumnos = new System.Windows.Forms.DataGridView();
            this.grbEdicionMateria = new System.Windows.Forms.GroupBox();
            this.btnBuscarMateria = new System.Windows.Forms.Button();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnNuevoMateria = new System.Windows.Forms.Button();
            this.grbNavegacionMateria = new System.Windows.Forms.GroupBox();
            this.lblRegistrosMateria = new System.Windows.Forms.Label();
            this.btnUltimoMateria = new System.Windows.Forms.Button();
            this.btnSiguienteMateria = new System.Windows.Forms.Button();
            this.btnAnteriorMateria = new System.Windows.Forms.Button();
            this.btnPrimeroMateria = new System.Windows.Forms.Button();
            this.grbDatosMateria = new System.Windows.Forms.GroupBox();
            this.lblUvMateria = new System.Windows.Forms.Label();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.lblCodigoMateria = new System.Windows.Forms.Label();
            this.txtCodigoMateria = new System.Windows.Forms.TextBox();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumnos)).BeginInit();
            this.grbEdicionMateria.SuspendLayout();
            this.grbNavegacionMateria.SuspendLayout();
            this.grbDatosMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarMateria
            // 
            this.lblBuscarMateria.AutoSize = true;
            this.lblBuscarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarMateria.Location = new System.Drawing.Point(414, 40);
            this.lblBuscarMateria.Name = "lblBuscarMateria";
            this.lblBuscarMateria.Size = new System.Drawing.Size(91, 24);
            this.lblBuscarMateria.TabIndex = 15;
            this.lblBuscarMateria.Text = "BUSCAR:";
            // 
            // txtBuscarMateria
            // 
            this.txtBuscarMateria.Location = new System.Drawing.Point(505, 45);
            this.txtBuscarMateria.Name = "txtBuscarMateria";
            this.txtBuscarMateria.Size = new System.Drawing.Size(330, 20);
            this.txtBuscarMateria.TabIndex = 16;
            // 
            // grdDatosAlumnos
            // 
            this.grdDatosAlumnos.AllowUserToAddRows = false;
            this.grdDatosAlumnos.AllowUserToDeleteRows = false;
            this.grdDatosAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateria,
            this.codigo,
            this.nombre,
            this.uv});
            this.grdDatosAlumnos.Location = new System.Drawing.Point(418, 71);
            this.grdDatosAlumnos.Name = "grdDatosAlumnos";
            this.grdDatosAlumnos.ReadOnly = true;
            this.grdDatosAlumnos.Size = new System.Drawing.Size(417, 252);
            this.grdDatosAlumnos.TabIndex = 14;
            // 
            // grbEdicionMateria
            // 
            this.grbEdicionMateria.Controls.Add(this.btnBuscarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnEliminarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnModificarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnNuevoMateria);
            this.grbEdicionMateria.Location = new System.Drawing.Point(229, 329);
            this.grbEdicionMateria.Name = "grbEdicionMateria";
            this.grbEdicionMateria.Size = new System.Drawing.Size(378, 58);
            this.grbEdicionMateria.TabIndex = 13;
            this.grbEdicionMateria.TabStop = false;
            this.grbEdicionMateria.Text = "Navegacion";
            // 
            // btnBuscarMateria
            // 
            this.btnBuscarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMateria.Location = new System.Drawing.Point(284, 19);
            this.btnBuscarMateria.Name = "btnBuscarMateria";
            this.btnBuscarMateria.Size = new System.Drawing.Size(83, 38);
            this.btnBuscarMateria.TabIndex = 7;
            this.btnBuscarMateria.Text = "Buscar";
            this.btnBuscarMateria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMateria.Location = new System.Drawing.Point(189, 19);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(97, 38);
            this.btnEliminarMateria.TabIndex = 6;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMateria.Location = new System.Drawing.Point(87, 19);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(104, 38);
            this.btnModificarMateria.TabIndex = 5;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            // 
            // btnNuevoMateria
            // 
            this.btnNuevoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMateria.Location = new System.Drawing.Point(6, 19);
            this.btnNuevoMateria.Name = "btnNuevoMateria";
            this.btnNuevoMateria.Size = new System.Drawing.Size(83, 38);
            this.btnNuevoMateria.TabIndex = 4;
            this.btnNuevoMateria.Text = "Nuevo";
            this.btnNuevoMateria.UseVisualStyleBackColor = true;
            // 
            // grbNavegacionMateria
            // 
            this.grbNavegacionMateria.Controls.Add(this.lblRegistrosMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnUltimoMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnSiguienteMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnAnteriorMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnPrimeroMateria);
            this.grbNavegacionMateria.Location = new System.Drawing.Point(10, 329);
            this.grbNavegacionMateria.Name = "grbNavegacionMateria";
            this.grbNavegacionMateria.Size = new System.Drawing.Size(213, 58);
            this.grbNavegacionMateria.TabIndex = 12;
            this.grbNavegacionMateria.TabStop = false;
            this.grbNavegacionMateria.Text = "Navegacion";
            // 
            // lblRegistrosMateria
            // 
            this.lblRegistrosMateria.AutoSize = true;
            this.lblRegistrosMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosMateria.Location = new System.Drawing.Point(76, 24);
            this.lblRegistrosMateria.Name = "lblRegistrosMateria";
            this.lblRegistrosMateria.Size = new System.Drawing.Size(63, 24);
            this.lblRegistrosMateria.TabIndex = 10;
            this.lblRegistrosMateria.Text = "x de n";
            // 
            // btnUltimoMateria
            // 
            this.btnUltimoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMateria.Location = new System.Drawing.Point(172, 14);
            this.btnUltimoMateria.Name = "btnUltimoMateria";
            this.btnUltimoMateria.Size = new System.Drawing.Size(35, 38);
            this.btnUltimoMateria.TabIndex = 3;
            this.btnUltimoMateria.Text = ">|";
            this.btnUltimoMateria.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteMateria
            // 
            this.btnSiguienteMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMateria.Location = new System.Drawing.Point(139, 14);
            this.btnSiguienteMateria.Name = "btnSiguienteMateria";
            this.btnSiguienteMateria.Size = new System.Drawing.Size(35, 38);
            this.btnSiguienteMateria.TabIndex = 2;
            this.btnSiguienteMateria.Text = ">";
            this.btnSiguienteMateria.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorMateria
            // 
            this.btnAnteriorMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMateria.Location = new System.Drawing.Point(40, 18);
            this.btnAnteriorMateria.Name = "btnAnteriorMateria";
            this.btnAnteriorMateria.Size = new System.Drawing.Size(35, 38);
            this.btnAnteriorMateria.TabIndex = 1;
            this.btnAnteriorMateria.Text = "<";
            this.btnAnteriorMateria.UseVisualStyleBackColor = true;
            // 
            // btnPrimeroMateria
            // 
            this.btnPrimeroMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroMateria.Location = new System.Drawing.Point(7, 18);
            this.btnPrimeroMateria.Name = "btnPrimeroMateria";
            this.btnPrimeroMateria.Size = new System.Drawing.Size(35, 38);
            this.btnPrimeroMateria.TabIndex = 0;
            this.btnPrimeroMateria.Text = "|<";
            this.btnPrimeroMateria.UseVisualStyleBackColor = true;
            // 
            // grbDatosMateria
            // 
            this.grbDatosMateria.Controls.Add(this.lblUvMateria);
            this.grbDatosMateria.Controls.Add(this.txtDireccionAlumno);
            this.grbDatosMateria.Controls.Add(this.lblNombreMateria);
            this.grbDatosMateria.Controls.Add(this.txtNombreAlumno);
            this.grbDatosMateria.Controls.Add(this.lblCodigoMateria);
            this.grbDatosMateria.Controls.Add(this.txtCodigoMateria);
            this.grbDatosMateria.Enabled = false;
            this.grbDatosMateria.Location = new System.Drawing.Point(9, 30);
            this.grbDatosMateria.Name = "grbDatosMateria";
            this.grbDatosMateria.Size = new System.Drawing.Size(390, 258);
            this.grbDatosMateria.TabIndex = 11;
            this.grbDatosMateria.TabStop = false;
            this.grbDatosMateria.Text = "Datos de Materia";
            // 
            // lblUvMateria
            // 
            this.lblUvMateria.AutoSize = true;
            this.lblUvMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUvMateria.Location = new System.Drawing.Point(31, 116);
            this.lblUvMateria.Name = "lblUvMateria";
            this.lblUvMateria.Size = new System.Drawing.Size(41, 24);
            this.lblUvMateria.TabIndex = 5;
            this.lblUvMateria.Text = "UV:";
            // 
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.Location = new System.Drawing.Point(131, 120);
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.Size = new System.Drawing.Size(251, 20);
            this.txtDireccionAlumno.TabIndex = 4;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMateria.Location = new System.Drawing.Point(31, 76);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(84, 24);
            this.lblNombreMateria.TabIndex = 3;
            this.lblNombreMateria.Text = "Nombre:";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(131, 80);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(251, 20);
            this.txtNombreAlumno.TabIndex = 2;
            // 
            // lblCodigoMateria
            // 
            this.lblCodigoMateria.AutoSize = true;
            this.lblCodigoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMateria.Location = new System.Drawing.Point(31, 37);
            this.lblCodigoMateria.Name = "lblCodigoMateria";
            this.lblCodigoMateria.Size = new System.Drawing.Size(76, 24);
            this.lblCodigoMateria.TabIndex = 1;
            this.lblCodigoMateria.Text = "Codigo:";
            // 
            // txtCodigoMateria
            // 
            this.txtCodigoMateria.Location = new System.Drawing.Point(131, 41);
            this.txtCodigoMateria.Name = "txtCodigoMateria";
            this.txtCodigoMateria.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoMateria.TabIndex = 0;
            // 
            // idMateria
            // 
            this.idMateria.DataPropertyName = "idMateria";
            this.idMateria.HeaderText = "ID";
            this.idMateria.Name = "idMateria";
            this.idMateria.ReadOnly = true;
            this.idMateria.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // uv
            // 
            this.uv.DataPropertyName = "uv";
            this.uv.HeaderText = "UV";
            this.uv.Name = "uv";
            this.uv.ReadOnly = true;
            // 
            // materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.lblBuscarMateria);
            this.Controls.Add(this.txtBuscarMateria);
            this.Controls.Add(this.grdDatosAlumnos);
            this.Controls.Add(this.grbEdicionMateria);
            this.Controls.Add(this.grbNavegacionMateria);
            this.Controls.Add(this.grbDatosMateria);
            this.Name = "materia";
            this.Text = "materia";
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumnos)).EndInit();
            this.grbEdicionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.PerformLayout();
            this.grbDatosMateria.ResumeLayout(false);
            this.grbDatosMateria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarMateria;
        private System.Windows.Forms.TextBox txtBuscarMateria;
        private System.Windows.Forms.DataGridView grdDatosAlumnos;
        private System.Windows.Forms.GroupBox grbEdicionMateria;
        private System.Windows.Forms.Button btnBuscarMateria;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnNuevoMateria;
        private System.Windows.Forms.GroupBox grbNavegacionMateria;
        private System.Windows.Forms.Label lblRegistrosMateria;
        private System.Windows.Forms.Button btnUltimoMateria;
        private System.Windows.Forms.Button btnSiguienteMateria;
        private System.Windows.Forms.Button btnAnteriorMateria;
        private System.Windows.Forms.Button btnPrimeroMateria;
        private System.Windows.Forms.GroupBox grbDatosMateria;
        private System.Windows.Forms.Label lblUvMateria;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label lblCodigoMateria;
        private System.Windows.Forms.TextBox txtCodigoMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn uv;
    }
}